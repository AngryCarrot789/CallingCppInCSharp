using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CppAndCs
{
    public class Program
    {

        public struct MyStruct
        {
            public int a, b;
        }

        public const string CppFunctionsDLL = @"..\..\..\Debug\CppFunctions.dll";

        [DllImport(CppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int AddNumbers(MyStruct vals);

        [DllImport(CppFunctionsDLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SubtractNumbers(MyStruct vals);

        static void Main(string[] args)
        {
            int input1, input2;

            Console.Write("Input number 1: ");

            if (!int.TryParse(Console.ReadLine(), out input1))
            {
                Console.WriteLine("Bad input. Setting input1 to 5");
                input1 = 5;
            }

            Console.Write("Input number 2: ");

            if (!int.TryParse(Console.ReadLine(), out input2))
            {
                Console.WriteLine("Bad input. Setting input2 to 10");
                input2 = 10;
            }

            MyStruct ms = new MyStruct();
            ms.a = input1;
            ms.b = input2;

            int output = SubtractNumbers(ms);

            Console.WriteLine($"Output is: {output}");

            Console.Read();
        }
    }
}
