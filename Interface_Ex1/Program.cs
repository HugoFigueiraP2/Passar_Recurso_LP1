using System;

namespace Interface_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape rect = new Rectangle(4,6);

            Console.WriteLine($"Circle Area: {circle.GetArea()}");
            Console.WriteLine($"Circle Perimenter: {circle.GetPerimeter()}");
            Console.WriteLine($"Rectangle Area: {rect.GetArea()}");
            Console.WriteLine($"Rectangle Perimenter: {rect.GetPerimeter()}");

        }
    }
}
