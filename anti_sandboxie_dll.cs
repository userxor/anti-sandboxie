using System;
using System.Runtime.InteropServices;
namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        static void Main(string[] args)
        {
            if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
            {
                Environment.Exit(0);
            }
            Console.ReadKey();
        }
    }
}
