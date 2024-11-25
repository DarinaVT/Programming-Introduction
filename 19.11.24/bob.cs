using System;
using System.Collections.Generic;

Console.WriteLine("Enter the capacity of the washing machine:");
int WashingMachineCapacity = int.Parse(Console.ReadLine());
int CleanPairs = 0;
int ToWash = 0;
int SinglesMatched = 0;
int PairsFromDirtySocks = 0;


// clean socks part
Console.WriteLine("Enter the amount of clean socks:");
int CleanSocksAmount = int.Parse(Console.ReadLine());
int[] CleanSocks = new int[CleanSocksAmount];

Console.WriteLine($"Enter {CleanSocksAmount} clean socks using numbers to identify the colour:");
for (int i = 0; i < CleanSocksAmount; i++)
{
    CleanSocks[i] = int.Parse(Console.ReadLine());
}
Array.Sort(CleanSocks);
List<int> CleanSocksList = CleanSocks.ToList();

for (int i = 0; i < CleanSocksList.Count - 1; i++)
{
    if (CleanSocksList[i] == CleanSocksList[i + 1])
    {
        CleanSocksList.RemoveAt(i + 1);
        CleanSocksList.RemoveAt(i);
        CleanPairs++;
    }
}

// dirty socks part
Console.WriteLine("Enter the amount of dirty socks:");
int DirtySocksAmount = int.Parse(Console.ReadLine());
int[] DirtySocks = new int[DirtySocksAmount];

Console.WriteLine($"Enter {DirtySocksAmount} dirty socks using numbers to identify the colour:");
for (int i = 0; i < DirtySocksAmount; i++)
{
    DirtySocks[i] = int.Parse(Console.ReadLine());
}
Array.Sort(DirtySocks);
List<int> DirtySocksList = DirtySocks.ToList();

// check with dirty and clean socks for maximum pairs

for (int i = 0; i < CleanSocksList.Count && ToWash < WashingMachineCapacity; i++)
{
    for (int j = 0; j < DirtySocksList.Count; j++)
    {
        if (CleanSocksList[i] == DirtySocksList[j])
        {
            CleanSocksList.RemoveAt(i);
            DirtySocksList.RemoveAt(j);
            ToWash++;
            SinglesMatched++;
            i--;
            break;
        }
    }
    if (DirtySocksList.Count == 0)
    {
        break;
    }
}

for (int i = 0; i < DirtySocksList.Count - 1 && ToWash + 2 <= WashingMachineCapacity;)
{
    if (DirtySocksList[i] == DirtySocksList[i + 1])
    {
        ToWash += 2;
        PairsFromDirtySocks++;
        DirtySocksList.RemoveAt(i + 1);
        DirtySocksList.RemoveAt(i);
    }
    else
    {
        i++;
    }
    if (DirtySocksList.Count == 0)
    {
        break;
    }
}
Console.WriteLine($"Bob can take the maximum of {CleanPairs + SinglesMatched + PairsFromDirtySocks} clean pairs.");
