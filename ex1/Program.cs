using System;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            newClass newClass = new newClass();
            newClass.Comparission("first", "Second");
            newClass.BiggestNumber(new int[] { 4, 2, 6, 9, 1});
            newClass.Sorting(new string[] { "Aparentemente", "asi", "esta", "ordenado", "si como no" });
            newClass.CountLenght("cuentamesta");

            class1 class1 = new class1();
            class1.FirstValues(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 });
            class1.SmallestNumber(new int[] { 8, 4, 5, 6, 2, 8 });
            class1.IterateDictionary();

        }

    }
}