using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2Assignment
{
    internal class DiceRoll
    {
        private int NumRolls;
        private Random rng = new Random();
        private int[] Combos = new int[11];
        
        // Constructor
        public DiceRoll(int NumRolls)
        {
            this.NumRolls = NumRolls;
        }

        // Roll method returns an array with the counnts of each number combination
        public int[] Roll()
        {
            for(int i = 0; i < NumRolls; i++)
            {
                // Randomly generates the two values, adds them, and puts them into the right index in the array
                int roll1 = rng.Next(1, 7);
                int roll2 = rng.Next(1, 7);
                int total = roll1 + roll2;
                Combos[total - 2]++;
            }
            // Returns completed array
            return Combos;
        }
    }
}
