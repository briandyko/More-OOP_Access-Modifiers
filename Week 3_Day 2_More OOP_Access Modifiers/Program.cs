using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_2_More_OOP_Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat boaty = new Boat(3, "Boaty", 18.6);   //(the three arguments listed here) a new instance of a boat.
            boaty.Move();
            boaty.BoatInfo();
            
            Boat boat2 = new Boat(14, "Boat 2", 30.8);
            boat2.BoatInfo();
            int numberOfPassengers = 5;
            boat2.BoatInfo();


        }
    }
}
