using System;
namespace PrimeSifting.Models
{
  class Prime
  {
    public static void GenerateSeries(int number)
    {
      int[] numbersArray = new int[number];
      int[] primeNum = new int[number];
      for (int i=2; i<=number;i++)
      {
        numbersArray[i - 2] = i;
      }

    for (int j=2; j<=number; j++)
      {
        if (numbersArray[j-2]%j !=0)
        {
          primeNum[j-2]=j;
        }
      }
      Console.WriteLine("Array line : "+ string.Join(",", primeNum));
    }
  }
  }
