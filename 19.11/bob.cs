using System;
using System.Collections.Generic;

Console.WriteLine("Enter the capacity of the washing machine:");
int WashingMachineCapacity = int.Parse(Console.ReadLine());
int CleanPairs = 0;
int ToWash = 0;

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
while (ToWash < WashingMachineCapacity)
{
    bool foundMatch = false;

    for (int i = 0; i < CleanSocksList.Count; i++)
    {
        for (int j = 0; j < DirtySocksList.Count; j++)
        {
            if (CleanSocksList[i] == DirtySocksList[j])
            {
                CleanSocksList.RemoveAt(i);
                DirtySocksList.RemoveAt(j);

                ToWash++;
                foundMatch = true;
                i--;
                break;
            }
        }

        if (foundMatch)
        {
            break;
        }
    }

    if (!foundMatch)
    {
        Console.WriteLine("No more matching socks to wash");
        break;
    }
}

Console.WriteLine($"Bob can take the maximum of {CleanPairs + ToWash} clean pairs");
