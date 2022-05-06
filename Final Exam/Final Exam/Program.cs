using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  ******************************************
            //  ***             Elevator 1             ***
            //  ******************************************


            //Declare elevator1 vairable
            Elevator elevator1;

            //Instatiate elevator1
            elevator1 = new Elevator(2, 400);

            //Adding Occupants
            elevator1.AddOccupant(new Passenger("A1", 180), 0);
            elevator1.AddOccupant(new Passenger("A2", 220), 1);

            //Declare bool variable
            bool elevator1IsOverMaxCapacity;

            //Assign bool value
            elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();


            //  ******************************************
            //  ***             Elevator 2             ***
            //  ******************************************


            //Declare elevator2 vairable
            Elevator elevator2;

            //Instatiate elevator2
            elevator2 = new Elevator(3, 600);

            //Adding Occupants
            elevator2.AddOccupant(new Passenger("A1", 200), 0);
            elevator2.AddOccupant(new Passenger("A2", 200), 1);
            elevator2.AddOccupant(new Passenger("A3", 201), 2);


            //Declare bool variable
            bool elevator2IsOverMaxCapacity;

            //Assign bool value
            elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();


            //  ******************************************
            //  ***     Optional Console Output        ***
            //  ******************************************


        }
    }
}
