using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
        Method method = new Method();
            //updated Changes
            method.getTeamInfo();
            method.printTeamInfo();

            Console.WriteLine();
            Console.WriteLine("[PRESS ENTER TO CLOSE]");

            Console.ReadLine();

            
        }
    }
}
