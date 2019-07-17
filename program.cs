using System;
using PrimeSifting.Models;
namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the number till you want to genrate the prime series ");
      int userNum= int.Parse(Console.ReadLine());
      Prime.GenerateSeries(userNum);
    }
  }
}
