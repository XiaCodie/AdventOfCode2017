using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<List<int>> numbers = new List<List<int>>();
            numbers.Add(new List<int>());

            int rowIndex = 0;

            for (int i = 0; i < args.Length; ++i)
            {
                if (args[i].Contains("\r\n"))
                {
                    string[] split = args[i].Split('\n');
                    numbers.ElementAt(rowIndex).Add(int.Parse(split[0]));

                    numbers.Add(new List<int>());
                    ++rowIndex;
                    numbers.ElementAt(rowIndex).Add(int.Parse(split[1]));
                }
                else
                {
                    numbers.ElementAt(rowIndex).Add(int.Parse(args[i]));
                }
            }

            List<int> divisions = new List<int>();
            for (int i = 0; i < numbers.Count; ++i)
            {
                for (int j = 0; j < numbers.ElementAt(i).Count; ++j)
                {
                    bool found = false;

                    for (int k = j + 1; k < numbers.ElementAt(i).Count; ++k)
                    {
                        if (
                            numbers.ElementAt(i).ElementAt(j) % numbers.ElementAt(i).ElementAt(k) == 0
                           )
                        {
                            divisions.Add(numbers.ElementAt(i).ElementAt(j) / numbers.ElementAt(i).ElementAt(k));
                            found = true;
                            break;
                        }
                        else if
                            (
                             numbers.ElementAt(i).ElementAt(k) % numbers.ElementAt(i).ElementAt(j) == 0
                            )
                        {
                            divisions.Add(numbers.ElementAt(i).ElementAt(k) / numbers.ElementAt(i).ElementAt(j));
                            found = true;
                            break;
                        }
                    }

                    if (found) break;
                }
            }

            int sum = 0;
            for (int i = 0; i < divisions.Count; ++i)
            {
                sum += divisions.ElementAt(i);
            }

            Console.WriteLine();
        }
    }
}
