﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LabAssigment_By_PedroMelo.Scripts {
    internal class DiceRoller {
        int numberOfSides = 6;
        int totalScore = 0;

        public void RollDice() {

            // creating a loop to start the game and roll the dice
            for (int x = 1; x <= 3; x++) {
                Console.WriteLine(" "); // blank space
                Console.WriteLine("Press any Key to play!");
                Console.ReadKey();
                Console.WriteLine(" "); // blank space

                // calling function RandomSide
                RandomSide();

                // printing the totalScore
                Console.WriteLine("Your total score is = " + totalScore);

                // calling function WinLose
                WinLose();
            }
        }

        private void RandomSide() {

            // creating instance RND
            Random rnd = new Random();

            // creating variable that will create random numbers
            int a = rnd.Next(1, numberOfSides);
            int b = rnd.Next(1, numberOfSides);
            int c = rnd.Next(1, numberOfSides);
            int d = rnd.Next(1, numberOfSides);

            // totalScore will calculate the variables a + b + c + d
            totalScore = a + b + c + d;

            Console.WriteLine("You rolled:");
            Console.Write("| " + a + " | ");
            Console.Write(b + " | ");
            Console.Write(c + " | ");
            Console.Write( d + " | ");

            Console.WriteLine(" "); // blank space
        }

        /* I DISABLED THIS BLOCK OF CODE BECAUSE THIS ASSIGNMENT IS SUPPOSED TO DO WITHOUT FOR LOOP
        private void RandomSideForLoop() {

            // creating instance RND
            Random rnd = new Random();

            Console.WriteLine("--ROLLING THE DICE--");

            // creating a loop for roll the dice randomly
            for (int x = 1; x <= 4; x++) {
                int rolls = rnd.Next(1, numberOfSides);
                Console.Write("Rolled: " + rolls + " | ");
                totalScore += rolls;
            }

            Console.WriteLine(" "); // blank space
        }
        */

        void WinLose() {
            if (totalScore >= 12) {
                Console.WriteLine("Good job you WON :)");
            }
            else {
                Console.WriteLine("!! LOSER !!");
            }
        }

    }

}