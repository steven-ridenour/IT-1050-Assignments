using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    internal class Pet
    {
        
        private string name;
        private string breed;
        private int age;
        private static int totalNumberOfPets = 0;
        private static int sumOfAllPetAges = 0;
        private static int counter = 1;

        public Pet ()
        {

            
            Console.WriteLine("What is the pet {0}'s name? ", counter);
            this.name = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("What is the pet {0}'s breed? ", counter);
            this.breed = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("What is the pet {0}'s age? ", counter);
            this.age = int.Parse(Console.ReadLine());

            Console.Clear();

            sumOfAllPetAges += age;
            counter++;
        }

        public void getDetails()
        {
            Console.WriteLine(name + " is " + age + " years old, and is a " + breed + ".");
        }
        public string getName()
        {
            return this.name;
        }

        public string getBreed()
        {
            return this.breed;
        }

        public int getAge()
        {
            return this.age;
        }

        public static int getTotalNumberOfPets()
        {
            return totalNumberOfPets;
        }

        public static int getSumOfAllPetAges()
        {
            return sumOfAllPetAges;
        }

        public static void setTotalNumberOfPets(int numOfPets)
        {
            totalNumberOfPets = numOfPets;
        }

       
        
    }
}
