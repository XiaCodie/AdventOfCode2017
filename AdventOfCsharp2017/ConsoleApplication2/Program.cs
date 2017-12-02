using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }

            string insert = args[0];

            // Muutetaan syötetty lista käsiteltäväksi listaksi
            List<uint> numbers = new List<uint>();
            for (int i = 0; i < insert.Length; ++i)
            {
                numbers.Add((uint)Char.GetNumericValue(insert.ElementAt(i)));
            }

            if (numbers.Count == 0)
            {
                return;
            }

            // Haetaan kaikki yhtäläiset numerot
            List<uint> matchingDigits = new List<uint>();
            for (int i = 1; i < numbers.Count / 2; ++i)
            {
                if (numbers[i] == numbers[i + (numbers.Count / 2)])
                {
                    matchingDigits.Add(numbers[i]);
                    matchingDigits.Add(numbers[i + (numbers.Count / 2)]);
                }
            }

            uint sum = 0;
            for (int i = 0; i < matchingDigits.Count; ++i)
            {
                sum += matchingDigits[i];
            }

            Console.WriteLine(sum);
        }
    }
}
