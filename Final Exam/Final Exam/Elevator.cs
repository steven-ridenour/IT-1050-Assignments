using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Elevator
    {

        //Private member variables
        private double MaxWeight;
        private Passenger[] Occupants;

        //Public Constructor
        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }



        //  ******************************************
        //  ***           Public Methods           ***
        //  ******************************************


        //AddOccupant Method
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        //GetCurrentWeight Method
        public double GetCurrentWeight()
        {
            double totalWeight = 0;

            //runs through each passenger in Occupants and adds their
            //weight to the total mesured by the double totalWeight
            foreach (Passenger passenger in Occupants)
            { 
                totalWeight += passenger.GetWeight();
            }
            return totalWeight;
        }

        //IsOVerMaxCapacity Method
        public bool IsOverMaxCapacity()
        {
            if (GetCurrentWeight() > MaxWeight)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
