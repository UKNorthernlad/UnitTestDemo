using System;
using MessageGenerator;

namespace MessageRunner

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mg = new MessageGen();
            mg.Message = "Tim";

            Console.WriteLine(mg.PrintMessage());
        }
    }
}