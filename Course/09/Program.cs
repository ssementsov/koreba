using System;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {
            float variable = 2.7182818284590452f;

            Byte b = (Byte)variable;
            Console.WriteLine($"byte {b}");

            SByte sb = (SByte)variable;
            Console.WriteLine($"sByte {sb}");

            Int16 sh = (Int16)variable;
            Console.WriteLine($"short {sh}");

            UInt16 ush = (UInt16)variable;
            Console.WriteLine($"ushort {ush}");

            Int32 i = (Int32)variable;
            Console.WriteLine($"int {i}");

            UInt32 ui = (UInt32)variable;
            Console.WriteLine($"uInt {ui}");

            Int64 L = (Int64)variable;
            Console.WriteLine($"long {L}");

            UInt64 uL = (UInt64)variable;
            Console.WriteLine($"uLong {uL}");

            Double d = (Double)variable;
            Console.WriteLine($"Double {d}");

            Decimal dec = (Decimal)variable;
            Console.WriteLine($"Decimal {dec}");

            Single s = (Single)variable;
            Console.WriteLine($"Float {s}");

            Console.Read();
        }
    }
}
