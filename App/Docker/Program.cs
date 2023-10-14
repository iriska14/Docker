// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int [] { 1, 2, 3 };
            var srt = string.Join (" ", array);
            Console.WriteLine(srt);
        }
    }   
}
