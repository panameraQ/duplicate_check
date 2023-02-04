using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace duplicate_check
{
    internal class Program
    {
        public static void Main()
        {
            string[] arr1 = { "cat", "dog", "bird" };
            string[] arr2 = { "dog", "bird", "cat" };

            // Проверка дубликатов слов в массивах. 
            foreach (string word1 in arr1)
            {
                foreach (string word2 in arr2)
                {
                    if (word1 == word2)
                    {
                        Console.WriteLine(word1 + " is a duplicate");
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
