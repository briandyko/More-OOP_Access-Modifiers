using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3_Day_2_More_OOP_Access_Modifiers
{
    class Boat    // a class is a blueprint. the plan for each object, though there are variations with the blueprint
    {
        // field - values used in program - describe characteristics. The actual information about that class that cause the variations.
        // in java - field is called instant variables - and c# and java are very very similar
        public int numberOfPassengers;   // since this is public, can be accessed anywhere, no need to set up property then.
        
        private string name;                   //90% we'll set fields to private, though there is other ways of thinking about when to go private/public
        private double engineSize;

        // Properties - things we can use to expose and modify private fields to other parts of the program.

        public string Name             // 99.9% of the time, properties will be public. private properties don't really serve any purpose, and are basically redundant.
        {
            get { return this.name; }     // getting the value of that field   the "this." is not needed, but personal preference
            set { this.name = value; }    //setting the value of that field    the "this." is not needed, but personal preference
        }

        //Constructors - use the constructor to make something.
        //Constructors are also 99.9% of the time public, since we need to call to them to create new instances.

        public Boat ()    //default constructor since no parameters. even if we don't create it, c# will create a default constructor behind the scenes.
        {

        }

        public Boat (int numberOfPassengers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }

        //Methods


        public void Move()     // can be accessed anywhere since it's public
        {
            Console.WriteLine(name + " moves forward.");
        }

        private double CalculateMPG()    // can only be accessed inside this class.
        {
            double MPG = engineSize * .5d;

            return MPG;
        }

        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine Size: " + engineSize);
            Console.WriteLine("MPG: " + CalculateMPG());  // even though CalculateMPG() is private, we are still within the class, so we can use it here. 
            Console.WriteLine();
        }

    }
}
