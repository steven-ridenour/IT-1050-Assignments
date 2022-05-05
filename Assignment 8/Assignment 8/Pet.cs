using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    internal class Pet
    { 
        private string name;
        private string breed;
        private int age;
        private static int totalNumberOfPets = 0;
        private static int sumOfAllPetAges = 0;

        
        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getBreed()
        {
            return this.breed;
        }

        public void setBreed(string breed)
        {
            this.breed = breed;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public static int getTotalNumberOfPets()
        {
            return totalNumberOfPets;
        }

        public static void setTotalNumberOfPets(int numOfPets)
        {
            totalNumberOfPets = numOfPets;
        }

        public static int getSumOfAllPetAges()
        {
            return sumOfAllPetAges;
        }

        public static void addAgeOfPets(int age)
        {
            sumOfAllPetAges += age;
        }
    }
}
