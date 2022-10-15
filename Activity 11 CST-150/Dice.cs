using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Activity_11_CST_150.Dice;

namespace Activity_11_CST_150
{
    public class Dice
    {
        // Declare a private integer to represent the number of sides. 
        private int numberOfSides;
        // Generate a random number of sides. 
        private static Random sides = new Random();

        // Dice Constructor, takes the number of sides as a parameter. 
        public Dice(int numberOfSides)
        {
            // If the number of sides is less than four or greater than 20, throw this exception. 
            if (numberOfSides < 4 || numberOfSides > 20)
            {
                throw new ArgumentOutOfRangeException("Out of range.");
            }

            this.numberOfSides = numberOfSides;
        }

        // Return the number of sides when this method is invoked. 
        public int rollDie()
        {
            return sides.Next(1, numberOfSides + 1);
        }
    }
}


