using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovChp18_01_CountNumPresence
{
    class CountNumInSeq
    {
        static void Main(string[] args)
        {
            string inputSeq = Console.ReadLine();
            string []inputNumbers = inputSeq.Split(new char[] {',', ' '},StringSplitOptions.RemoveEmptyEntries);

            SortedDictionary<int, int> uniqueNum = new SortedDictionary<int, int>();
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                int currNum = Convert.ToInt32(inputNumbers[i]);

                if(uniqueNum.ContainsKey(currNum))
                {
                    uniqueNum[currNum]++;
                }

                else
                {
                    uniqueNum.Add(currNum, 1);
                }
            }

            foreach(var number in uniqueNum)
            {
                Console.WriteLine("{0}->{1}", number.Key, number.Value);
            }

        }
    }
}
