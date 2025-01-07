using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter amount of clean socks: ");
        int cleanSocksAmount = int.Parse(Console.ReadLine());
        Console.Write("Enter amount of dirty socks: ");
        int dirtySocksAmount = int.Parse(Console.ReadLine());
        Console.Write("Enter washing machine capacity: ");
        int washingMachineCapacity = int.Parse(Console.ReadLine());

        int[] cleanSocksColours = new int[cleanSocksAmount];
        int[] dirtySocksColours = new int[dirtySocksAmount];

        Console.WriteLine("Enter the colour for each clean sock:");
        for (int i = 0; i < cleanSocksAmount; i++)
        {
            cleanSocksColours[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter the colour for each dirty sock:");
        for (int i = 0; i < dirtySocksAmount; i++)
        {
            dirtySocksColours[i] = int.Parse(Console.ReadLine());
        }

        Solution solve = new Solution();
        int result = solve.solution(washingMachineCapacity, cleanSocksColours, dirtySocksColours);
        Console.WriteLine($"Bob will have {result} clean pairs of socks in total");
    }
}
class Solution
{
    public int solution(int K, int[] C, int[] D)
    {
        int cleanPairs = 0;
        int pairsWithDirty = 0;

        List<int> cleanSocks = C.ToList();
        List<int> dirtySocks = D.ToList();

        cleanSocks.Sort();
        dirtySocks.Sort();

        for (int i = 0; i < cleanSocks.Count - 1;)
        {
            if (cleanSocks[i] == cleanSocks[i + 1])
            {
                cleanSocks.RemoveAt(i);
                cleanSocks.RemoveAt(i);
                cleanPairs++;
            }
            else
            {
                i++;
            }
        }

        for (int i = 0; i < cleanSocks.Count && pairsWithDirty < K;)
        {
            int matchingIndex = dirtySocks.IndexOf(cleanSocks[i]);
            if (matchingIndex != -1)
            {
                dirtySocks.RemoveAt(matchingIndex);
                cleanSocks.RemoveAt(i);
                pairsWithDirty++;
            }
            else
            {
                i++;
            }
        }

        for (int i = 0; i < dirtySocks.Count - 1 && pairsWithDirty < K;)
        {
            if (dirtySocks[i] == dirtySocks[i + 1])
            {
                dirtySocks.RemoveAt(i);
                dirtySocks.RemoveAt(i);
                pairsWithDirty++;
            }
            else
            {
                i++;
            }
        }

        return cleanPairs + pairsWithDirty;
    }
}
