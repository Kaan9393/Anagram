using System;

namespace ExpleoProgTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDetect Anagram\n");

            while (true)
            {

                Console.WriteLine("Skriv in första ordet:");
                string input1 = Console.ReadLine().ToLower();

                Console.WriteLine("Skriv in andra ordet:");
                string input2 = Console.ReadLine().ToLower();

                if (AnagramCheck(input1, input2))
                {
                    Console.WriteLine($"{input1} är en anagram av {input2}");
                }

                else
                {
                    Console.WriteLine($"{input1} är INTE en anagram av {input2}");
                }
            }
        }

        public static bool AnagramCheck(string input1, string input2)
        {
            if (input1 == null || input2 == null && input1.Length != input2.Length)
            {
                return false;
            }

            //gör en ny instans av inmatning till en array av bokstäver
            var input1Array = input1.ToCharArray();
            var input2Array = input2.ToCharArray();

            //sorterar varje bokstav i inmatningen
            Array.Sort(input1Array);
            Array.Sort(input2Array);

            input1 = new string(input1Array);
            input2 = new string(input2Array);

            return Array.Equals(input1, input2);
            
        }

    }
}
