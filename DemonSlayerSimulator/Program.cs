using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemonSlayerSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //call players function
            players();

            //keep window open
            Console.ReadKey();



        }
        //1.Create a function to hold information on the player and opponent as well as commands.
        static void players()
        {



            //declare variables to represent players health
            int playerHealth = 710;
                //declare a variable to represent the demons health
            int demonHealth = 666;



           
            //declare variables to represent player attacks
            
            int scytheSlash = 1;
            int crossAttack = 2;
            int holyWater = 3;


            //open a while loop that runs whle playerhealth and demonhealth is greater than 0
            while (playerHealth > 0 || demonHealth > 0);
            {

                //make a new random numbr generator
                Random rng = new Random();
                //declare a number for the user to input
                int userNum;
                Console.WriteLine("Enter 1 to perform a scytheSLash. /n Enter 2 for crossAttack. /n Enter 3 to use Holy Water");
                userNum = Convert.ToInt32(Console.ReadLine());


                //run the RNG
                int randomNum = rng.Next(1, 101);
                //if the user (player) enters 1 then they have a70% chance to deal 100 damage to the demon
                if (userNum == 1)
                {
                    if (randomNum > 30)
                    {
                        demonHealth = demonHealth - 100;
                    }
                }
                    //if the user (player) enters 2 then they have a 100% chance to deal 60 damage to the demon and heal themselves for 40
                else if (userNum == 2)
                {
                    if (randomNum > 0)
                    {

                        demonHealth = demonHealth - 60;
                        playerHealth = playerHealth + 40;

                    }
                }
                    //if the user (player) enters 3 gives a 30% chance to heal the player for 200 health or a 70% chance to heal the player for 100 health
                else if (userNum == 3)
                {
                    if (randomNum >= 70)
                    {
                        playerHealth = playerHealth + 200;
                    }
                    else if (randomNum <= 70)
                    {
                        playerHealth = playerHealth + 100;
                    }
                }
                

                    //the demon has a 5% chance to instantly kill you
                else if (randomNum > 95)
                {
                    playerHealth = playerHealth - 1000000000;

                    Console.WriteLine("The demon tears off your head");
                }
                    // the demon has a 10% chance to deal 300 damage
                else if (randomNum < 95 && randomNum > 85) 
                {
                    playerHealth = playerHealth - 300;
                    Console.WriteLine("The demon lashes out and sinks his long sword sharp teeth into your neck");
                }
                    //the demon has a 10% chance to deal 250 damge
                else if (randomNum < 85 && randomNum > 75) 
                {
                    playerHealth = playerHealth - 250;
                    Console.WriteLine("The demon slashes his saw blade like claws in a flurry, striking you several times");
                }
                    // the demon has a 25% chance to deal 175 damage
                else if (randomNum < 75 && randomNum > 50)
                {
                    playerHealth = playerHealth - 175;
                    Console.WriteLine ("The demon hits you with his heavy, spikey tail");
                }
                    // the demon has a 40% chance to deal 40 damage
                else if (randomNum < 50 && randomNum > 10)
                {
                    playerHealth = playerHealth - 40;
                    Console.WriteLine ("The demon stomps knocking you on the ground momentarily and doing injurying you slightly");
                }
                    // the demon has a 10% chance to deal 400 damage and heal itself for the damage dealt
                else if (randomNum < 10 && randomNum > 1)
                {
                    playerHealth = playerHealth - 400;
                        demonHealth = demonHealth + 400;
                    Console.WriteLine ("The demon lets out a howl that burns your brain and sucks the life right out of you, dealing massive amounts of damage and healing for the amount of damage done");
                }
                    // if the demonhealth = 0 or less than 0 then you win
                else if (demonHealth <= 0)
                {
                    Console.WriteLine("Congratulations you win");

                }
                    //if the playerhealth = 0 or less than 0 then you lose
                else if (playerHealth <= 0)
                {
                    Console.WriteLine("You fail and will rot for eternity");

                }
            }



        }
    }
}
