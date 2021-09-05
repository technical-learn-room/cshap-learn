using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte minSbyte = -128;
            sbyte maxSbyte = 127;

            byte minByte = 0;
            byte maxByte = 255;

            short minShort = -32768;
            short maxShort = 32767;

            ushort minUshort = 0;
            ushort maxUshort = 65535;

            int minInt = -2147483648;
            int maxInt = 2147483647;

            uint minUint = 0;
            uint maxUint = 4294967295;

            long minLong = -9223372036854775808L;
            long maxLong = 9223372036854775807L;

            ulong minUlong = 0L;
            ulong maxUlong = 18446744073709551615L;

            char minChar = '\0';
            char maxChar = '\uFFFF';

            float minFloat = -3.402823E+38F;
            float maxFloat = 3.402823E+38F;

            double minDouble = -1.7976931348623157E+308D;
            double maxDouble = 1.7976931348623157E+308D;

            bool minBool = false;
            bool maxBool = true;

            decimal minDecimal = -79228162514264337593543950335M;
            decimal maxDecimal = 79228162514264337593543950335M;
            
            Console.WriteLine($"sbyte min value: {minSbyte}");
            Console.WriteLine($"sbyte max value: {maxSbyte}");
            Console.WriteLine($"byte min value: {minByte}");
            Console.WriteLine($"byte max value: {maxByte}");
            Console.WriteLine($"short min value: {minShort}");
            Console.WriteLine($"short max value: {maxShort}");
            Console.WriteLine($"ushort min value: {minUshort}");
            Console.WriteLine($"ushort max value: {maxUshort}");
            Console.WriteLine($"int min value: {minInt}");
            Console.WriteLine($"int max value: {maxInt}");
            Console.WriteLine($"uint min value: {minUint}");
            Console.WriteLine($"uint max value: {maxUint}");
            Console.WriteLine($"long min value: {minLong}");
            Console.WriteLine($"long max value: {maxLong}");
            Console.WriteLine($"ulong min value: {minUlong}");
            Console.WriteLine($"ulong max value: {maxUlong}");
            Console.WriteLine($"char min value: {minChar}");
            Console.WriteLine($"char max value: {maxChar}");
            Console.WriteLine($"float min value: {minFloat}");
            Console.WriteLine($"float max value: {maxFloat}");
            Console.WriteLine($"double min value: {minDouble}");
            Console.WriteLine($"double max value: {maxDouble}");
            Console.WriteLine($"bool min value: {minBool}");
            Console.WriteLine($"bool max value: {maxBool}");
            Console.WriteLine($"decimal min value: {minDecimal}");
            Console.WriteLine($"decimal max value: {maxDecimal}");
        }
    }
}
