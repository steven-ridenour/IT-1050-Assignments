using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Method
    {
        // creating variables
        string teamName;
        int teamSize;
        string[] playerNames;
        int[] playerNumbers;



        public void getTeamInfo()
        {
            //Ask the user to input the name of their team and assign that value to teamName
            Console.Write("Enter your Team Name: ");
            teamName = Console.ReadLine();
            Console.WriteLine();

            //Ask the user to input the size of their team and assign that value to teamSize
            Console.Write("Enter your Team Size: ");
            teamSize = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Allocate enough memory for the playerNames array based on teamSize
            playerNames = new string[teamSize];

            //Allocate enough memory for the playerNumbers array based on teamSize
            playerNumbers = new int[teamSize];

            /*Write a for loop that declares an int variable i to iterate teamSize times.
                • Within that loop, at each iteration:
                    o Ask the user for the current (i th) player’s name.
                    o Store the input value in the current (i th) position in the playerNames array.
                    o Ask the user for the current (i th) player’s number.
                    o Store the input value in the current (i th) position in the playerNumbers array.
        */
            for (int i = 0; i < teamSize; i++)
            {
                Console.Write("Enter player {0}'s name: ", i + 1);
                playerNames[i] = Console.ReadLine();
                Console.WriteLine();

                Console.Write("Enter player {0}'s jersey number: ", i + 1);
                playerNumbers[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
        }

        //Write a void method called printTeamInfo
        public void printTeamInfo()
        {
            //Print the teamName to the screen
            Console.WriteLine(teamName);
            Console.WriteLine();

            /* Write a for loop that declares an int variable i to iterate teamSize times.
                • Within that loop, at each iteration:
                    o Print the the current (i th) player’s number to the screen.
                    o Print the the current (i th) player’s name to the screen.
            */
            for (int i = 0; i < teamSize; i++)
            {
                Console.Write(playerNumbers[i]);
                Console.Write(" ");
                Console.WriteLine(playerNames[i]);
            }
        }
    }
}
