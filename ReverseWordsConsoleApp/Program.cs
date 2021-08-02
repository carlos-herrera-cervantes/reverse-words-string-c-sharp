using System;
using ReverseWordsDomain.Models;

namespace ReverseWordsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "the sky is blue";
            var result = SuperString.ReverseString(str);
            
            Console.WriteLine($"THE RESULTING STRING IS {result}");
        }
    }
}
