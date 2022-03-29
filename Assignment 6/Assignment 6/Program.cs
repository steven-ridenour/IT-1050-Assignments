using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //updated 
            /*
           Create a class called Pet.
               Every Pet has a name, which is a string.
               Every Pet has an age, which is an integer.
               Every Pet has a breed, which is a string.

           Ask the user to input how many Pet(s) they own.

           For each pet they own, ask them the name, age, and breed of the Pet.

           For each Pet the user has specified"
               Declare, instantiate a Pet object.
               Populate the Pet object with the user-specified values for each member variable.

           When the user is finished inputting data, and your Pet objects are created and populated:
               For each Pet, print one sentence to the screen displaying all three member variables.
               Print one sentence to the screen identifying which Pet is the youngest.
               Print one sentence to the screen identifying which Pet is the oldest

           */




            // Asks how many pets are owned
            Console.WriteLine("How many pets do you own?");
            int petAmount = (int.Parse(Console.ReadLine()));

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
            Console.WriteLine("");
            Console.WriteLine("The youngest pet is " + youngest.name + " at " + youngest.age + " years old.");
            Console.WriteLine("The oldest pet is " + oldest.name + " at " + oldest.age + " years old.");

            Console.WriteLine("");
            Console.WriteLine("[PRESS ENTER TO CLOSE]");
            Console.ReadLine();
        }
    }
}
