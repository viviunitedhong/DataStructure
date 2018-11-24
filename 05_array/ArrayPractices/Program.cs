using System;

namespace ArrayPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            var testArray = new Array(5);
            testArray.Insert(0, 5);
            testArray.Insert(0, 3);
            testArray.Insert(2, 2);
            testArray.Insert(4, 4); //Invalid index
            testArray.PrintAll();

            Console.WriteLine("Find index {0}, value: {1}", 1, testArray.Find(1));

            Console.WriteLine("Remove index {0}", 1);
            testArray.Remove(1);
            testArray.PrintAll();

            Console.WriteLine("Insert {0} into index {1}", 8, 1);
            testArray.Insert(1, 8);
            testArray.PrintAll();

            Console.ReadLine();
        }
    }
}
