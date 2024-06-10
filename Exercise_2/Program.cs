using System;


namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal [] animal_array = new Animal[10];
            Random random_animal = new Random();
            for(int i = 0; i < animal_array.Length; i++)
            {
                switch (random_animal.Next(4))
                {
                    case 0:
                    {
                        animal_array[i] = new Cat();
                        break;
                    }
                    case 1:
                    {
                        animal_array[i] = new Dog();
                        break;
                    }
                    case 2:
                    {
                        animal_array[i] = new Bee();
                        break;

                    }
                    case 3:
                    {
                        animal_array[i] = new Bat();
                        break;
                    }
                }
            }

            foreach(Animal current_animal in animal_array)
            {
                Console.Write(current_animal.GetType().Name);
                Console.Write(current_animal.Sound());
                

                if(current_animal is IMammal)
                {
                    Console.Write(" Number of tities: " + (current_animal as IMammal).NumberOfNipples);
                }

                if(current_animal is ICanFly)
                {
                    Console.Write(" Number of Wings: " + (current_animal as ICanFly).NumberOfWings);

                }
                Console.WriteLine();

            }




            
        }
    }
}
