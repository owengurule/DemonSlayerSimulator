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

            




        }
        //1.Create a function to hold information on the player and opponent as well as commands.
        static void players(string demon, String player)
        {



            //declare variables to represent players health
            int playerHealth = 710;
                //declare a variable to represent the demons health
            int demonHealth = 666;


            Random rng = new Random();

            int userNum;
            Console.WriteLine("Enter 1 to perform a scytheSLash. /n Enter 2 for crossAttack");
            userNum = Convert.ToInt32(Console.ReadLine());
           
            //player attacks
            
            int scytheSlash = 1;
            int crossAttack = 2;
            int holyWater = 3;

            int randomNum = rng.Next(1, 101);

            while (playerHealth >= 0 || demonHealth >=0);
            {


                if (userNum == 1)
                {
                   if (randomNum > 30)
                   {
                       Console.WriteLine(demonHealth - 100);
                   }
                }
                else if (userNum == 2)
                {
                    if (randomNum > 0)
                    {
                        Console.WriteLine(demonHealth - 60);
                        
                        Console.WriteLine(playerHealth + 10);
                    }
                }
                else if (userNum == 3)
                {
                    if (randomNum >= 70)
                    {
                        Console.WriteLine(playerHealth + 200);
                    }
                    else if (randomNum <= 70)
                    {
                        Console.WriteLine(playerHealth + 100);
                    }
                }
                else if (demonHealth <= 0)
                {
                    Console.WriteLine("Congratulations you win");

                }



            }



        }
    }
}
