using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Asks how many pets are owned
            Console.WriteLine("How many pets do you own?");
            Pet.setTotalNumberOfPets(int.Parse(Console.ReadLine()));
            Console.Clear();


            // Creates an Array of pets of size according to previous question
            Pet[] pets = new Pet[Pet.getTotalNumberOfPets()];

            for (int i = 0; i < Pet.getTotalNumberOfPets(); i++)
            {
                pets[i] = new Pet();
            }

            for (int i = 0; i < Pet.getTotalNumberOfPets(); i++)
            {
                pets[i].getDetails();

            }

            Pet youngest = pets[1];
            Pet oldest = pets[1];

            for (int i = 0; i < Pet.getTotalNumberOfPets(); i++)
            {
                if (pets[i].getAge() > youngest.getAge())
                {
                    oldest = pets[i];

                }
                if (pets[i].getAge() < youngest.getAge())
                {
                    youngest = pets[i];

                }
            }

            double averageAge = (double)Pet.getSumOfAllPetAges() / (double)Pet.getTotalNumberOfPets();

            Console.WriteLine("");
            Console.WriteLine("The youngest pet is " + youngest.getName() + " at " + youngest.getAge() + " years old.");
            Console.WriteLine("The oldest pet is " + oldest.getName() + " at " + oldest.getAge() + " years old.");
            Console.WriteLine("");
            Console.WriteLine("The average pet age is: " + averageAge);






            Console.WriteLine("");
            Console.WriteLine("[PRESS ENTER TO CLOSE]");
            Console.ReadLine();
        }
    }
}
