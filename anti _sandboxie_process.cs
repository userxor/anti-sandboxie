using System;
using System.Diagnostics;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] kill = Process.GetProcessesByName("SbieCtrl");
            foreach (Process SbieCtrl in kill)
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
