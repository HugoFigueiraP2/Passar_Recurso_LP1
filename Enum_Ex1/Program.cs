using System;

namespace Enum_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberCollection collection = new NumberCollection();
            collection.Add(1);
            collection.Add(2);
            collection.Add(2);

            foreach (int number in collection)
            {
                Console.WriteLine(number);
            }
        }
    }
}
