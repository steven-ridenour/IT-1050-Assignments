using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Passenger
    {

        //Private member variables
        private string Name;
        private double Weight;

        //Public constructor
        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

        }

        //GetName method
        public string GetName()
            { return this.Name; }
        public double GetWeight()
            { return this.Weight; }
    }
}
