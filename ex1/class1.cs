using System;
using System.Collections.Generic;

namespace ex1
{
    public class class1
    {
        public void FirstValues(List<int> values)
        {
            Console.WriteLine("** Print the first five values from a list **");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(values[i]);
            }
        }

        public void SmallestNumber(int[] arr)
        {
            Console.WriteLine("** Iterate trough an Array and print the smallest number **");
            var min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                int number = arr[i];
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min.ToString(), "\n");
        }

        public void IterateDictionary()
        {
            Console.WriteLine("** Iterate trough a Dictionary and print the value **");
            var dict = new Dictionary<string, string>()
            {
                {"dog","black"},
                {"cat","white"},
                {"elephant","grey"},
                {"fox","orange"},
                {"lizard","green"}
            };
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
    }
}

