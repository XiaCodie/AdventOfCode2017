using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Part1
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
            for (int i = 0; i < insert.Length; ++i) {
                numbers.Add((uint)Char.GetNumericValue(insert.ElementAt(i)));
            }

            if (numbers.Count == 0)
            {
                return;
            }

            // Haetaan kaikki yhtäläiset numerot
            List<uint> matchingDigits = new List<uint>();
            for (int i = 1; i < numbers.Count; ++i) {
                if (numbers[i] == numbers[i - 1])
                {
                    matchingDigits.Add(numbers[i]);
                }
            }

            // Lisätään vielä viimeinen luku, jos se täsmää ensimmäisen
            // kanssa
            if (numbers[0] == numbers[numbers.Count - 1])
            {
                matchingDigits.Add(numbers[0]);
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
