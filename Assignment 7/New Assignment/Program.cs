using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            //instantiate static variables
            Pet.totalNumberOfPets = 0;
            Pet.sumOfAllPetAges = 0;


            // Asks how many pets are owned
            Console.WriteLine("How many pets do you own?");
            int petAmount = (int.Parse(Console.ReadLine()));
            Pet.totalNumberOfPets = petAmount;

            // Creates an Array of pets of size according to previous question
            Pet[] pets = new Pet[petAmount];

            for (int i = 0; i < petAmount; i++)
            {
                pets[i] = new Pet();

                Console.WriteLine("");
                Console.WriteLine("What is pet {0}'s name? ", i + 1);
                pets[i].name = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("What is pet {0}'s age? ", i + 1);
                pets[i].age = int.Parse(Console.ReadLine());
                Pet.sumOfAllPetAges += pets[i].age;

                Console.WriteLine("");
                Console.WriteLine("What is pet {0}'s breed? ", i + 1);
                pets[i].breed = Console.ReadLine();

            }

            Console.Clear();

            for (int i = 0; i < petAmount; i++)
            {

                Console.WriteLine(pets[i].name + " is " + pets[i].age + " years old, and is a " + pets[i].breed + ".");
            }

            Pet youngest = pets[1];
            Pet oldest = pets[1];

            for (int i = 0; i < petAmount; i++)
            {
                if (pets[i].age > youngest.age)
                {
                    youngest = pets[i];

                }
                if (pets[i].age < youngest.age)
                {
                    youngest = pets[i];

                }
            }

            double averageAge = (double)Pet.sumOfAllPetAges / (double)Pet.totalNumberOfPets;

            Console.WriteLine("");
            Console.WriteLine("The youngest pet is " + youngest.name + " at " + youngest.age + " years old.");
            Console.WriteLine("The oldest pet is " + oldest.name + " at " + oldest.age + " years old.");
            Console.WriteLine("");
            Console.WriteLine("The average pet age is: " + averageAge + "." ) ;






            Console.WriteLine("");
            Console.WriteLine("[PRESS ENTER TO CLOSE]");
            Console.ReadLine();
        }
    }
}
