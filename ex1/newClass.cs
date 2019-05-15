using System;
using System.Linq;

namespace ex1
{
    public class newClass
    {
        public newClass()
        {
        }

        public string Comparission(string one, string two)
        {
            //Comparision String
            Console.WriteLine("** Compare between to strings **");

            if (one != null && two != null)
            {
                throw new ArgumentNullException();

            }

            try
            {
                if (string.ReferenceEquals(one, two))
                    Console.WriteLine("one and two are equals \n");
                else
                    Console.WriteLine("one and two are not equals \n");
            }
            catch (Exception e )
            {
                Console.WriteLine("There are no strings to compare in the parameters ({0})",e);
            }

           /* if (one!= null && two!= null)
            {
                if (string.ReferenceEquals(one, two))
                    Console.WriteLine("one and two are equals \n");
                else
                    Console.WriteLine("one and two are not equals \n");
            }
            else
            {
                Console.WriteLine("There are no strings to compare in the parameters");
            } */


            return null;

        }
        public bool BiggestNumber(int[] numbers)
        {
            //Verify the biggest number in a list
            Console.WriteLine("** Print the biggest number from an array **");

            //int[] numbers = { 4, 2, 6, 9, 1 };
            int max = numbers[0];
            for (int j = 1; j < numbers.Length; j++)
            {
                if (numbers[j] > max)
                {
                    max = numbers[j];
                }
            }
            Console.WriteLine("The maximun element is: {0} \n", max);
            return false;

        }
        public void Sorting(string[] sorted)
        {

            //Sort a list by asc and desc order
            Console.WriteLine("** Sort an array asc and desc **");

            Array.Sort(sorted);
            foreach (string str in sorted)
            Console.WriteLine(str, "/n");

            Console.WriteLine("** Reverse **");
            Array.Reverse(sorted);
            foreach (string str in sorted)
            {
                Console.WriteLine(str.ToString());
            }


        }
        public int CountLenght(string word)
        {
            //Count the lenght of a string
            Console.WriteLine("** Count the lenght of a string **");

            int l = 0;
            Console.WriteLine("Enter a string");
            word = Console.ReadLine();

            foreach (char chr in word)
            {
                l += 1;
            }
            Console.WriteLine("The lenght of the string is {0} \n", l);

            return 0;
            
        }
    }
}
