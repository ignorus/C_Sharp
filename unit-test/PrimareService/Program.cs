using System;
using Prime.Services;

namespace PrimareService
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrimeService testar = new PrimeService();
            System.Console.WriteLine(testar.IsPrime());
        }
    }
}