using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
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
                    numbers.ElementAt(rowIndex).Add(int.Parse(split[0]) );

                    numbers.Add(new List<int>());
                    ++rowIndex;
                    numbers.ElementAt(rowIndex).Add(int.Parse(split[1]));
                }
                else
                {
                    numbers.ElementAt(rowIndex).Add(int.Parse(args[i]));
                }
            }

            List<int> differences = new List<int>();

            for (int i = 0; i < numbers.Count; ++i)
            {
                differences.Add( numbers.ElementAt(i).Max() - numbers.ElementAt(i).Min() );
            }

            int sum = 0;
            for (int i = 0; i < differences.Count; ++i)
            {
                sum += differences.ElementAt(i);
            }

            Console.WriteLine(sum);
        }
    }
}
