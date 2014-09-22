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
            DisplayHighScores();

            Console.WriteLine("Welcome to DemonSlayer" +
                "\nYou open your eyes to to see your room, what a night now you have to make it to school with two hours of sleep." +
                "\nYou stretch out and go to the bathroom to comb your hair, just like any other day." +
                "\nYou find yourself looking in the bathroom mirror when all of the sudden, the lights go out and you are surrounded by darkness" +
                "\n Something does not feel right, as if you are dizzy, but it feels as if you are on an elevator going down." +
                "\nAll of the sudden things began to brighten, but only to become dim, and reveal a dark stone room with nothing in it that is undiscribeably flooding with heat." +
                "\nYou hear your name grunted into your ear. You turn around and find yourself face to face with a creature beyond your belief, leaving you awestruck and silent." +
                "\nThe creature speaks in a voice that shatters the sound frequency you know echoing through your head, angrily the beast chants." +
                "\n'You have cheated death, and your soul belongs to my master Satan, I have come to deliver you to him, you have one last chance to cheat death," +
                "\n and that is to beat me in battle, infront of me I have the weapons of a fierce warrior who battled his way through hell, strike me now for your last chance of life'" +
                "\nYou gaze preparing to fight for your eternal life.");

            players();

            Console.ReadKey();



        }
        //1.Create a function to hold information on the player and opponent as well as commands.
        static void players()
        {



            //declare variables to represent players health
            int playerHealth = 710;
                //declare a variable to represent the demons health
            int demonHealth = 666;



           
            //player attacks
            
            int scytheSlash = 1;
            int crossAttack = 2;
            int holyWater = 3;

            bool playing = true;

            while (playing)
            {
                Random rng = new Random();

                int userNum;
                Console.WriteLine("Enter 1 to perform a scytheSLash which has a 70% chance to do 100 damage." +
                "\nEnter 2 for crossAttack which has a 100% chance of doing 60 damage, and healing you for 20 HP." +
                "\nEnter 3 to use Holy Water which has a 30% chance to heal for 200 and a 70% chance to heal for 100");
                userNum = Convert.ToInt32(Console.ReadLine());



                int randomNum = rng.Next(1, 101);

                if (userNum == 1)
                {
                    if (randomNum > 30)
                    {
                        demonHealth = demonHealth - 100;
                        Console.WriteLine("You landed a Scythe Slash dealing 100 damage.");
                        Console.WriteLine(demonHealth);
                        Console.WriteLine(playerHealth);
                    }
                }
                else if (userNum == 2)
                {
                    if (randomNum > 0)
                    {

                        demonHealth = demonHealth - 60;
                        playerHealth = playerHealth + 20;
                        Console.WriteLine("You absorb HP from the demon with your cross burning his flesh");
                        Console.WriteLine(demonHealth);
                        Console.WriteLine(playerHealth);
                    }
                }
                else if (userNum == 3)
                {
                    if (randomNum >= 70)
                    {
                        playerHealth = playerHealth + 200;
                        Console.WriteLine("You use your Holy Water, which critcal heals you for 200");
                        Console.WriteLine(demonHealth);
                        Console.WriteLine(playerHealth);
                    }
                    else if (randomNum <= 70)
                    {
                        playerHealth = playerHealth + 100;
                        Console.WriteLine("You use your Holy Water, which heals you for 100");
                        Console.WriteLine(demonHealth);
                        Console.WriteLine(playerHealth);
                    }
                }
                


                if (randomNum > 95)

                {
                    playerHealth = playerHealth - 1000000000;

                    Console.WriteLine("The demon tears off your head");
                    Console.WriteLine(demonHealth);
                    Console.WriteLine(playerHealth);
                }
                else if (randomNum < 95 && randomNum > 85) 
                {
                    playerHealth = playerHealth - 300;
                    Console.WriteLine("The demon lashes out and sinks his long sword sharp teeth into your neck");
                    Console.WriteLine(demonHealth);
                    Console.WriteLine(playerHealth);
                }
                else if (randomNum < 85 && randomNum > 75) 
                {
                    playerHealth = playerHealth - 250;
                    Console.WriteLine("The demon slashes his saw blade like claws in a flurry, striking you several times");
                    Console.WriteLine(demonHealth);
                    Console.WriteLine(playerHealth);
                }
                else if (randomNum < 75 && randomNum > 50)
                {
                    playerHealth = playerHealth - 175;
                    Console.WriteLine ("The demon hits you with his heavy, spikey tail");
                    Console.WriteLine(demonHealth);
                    Console.WriteLine(playerHealth);
                }
                else if (randomNum < 50 && randomNum > 10)
                {
                    playerHealth = playerHealth - 40;
                    Console.WriteLine ("The demon stomps knocking you on the ground momentarily and doing injurying you slightly");
                    Console.WriteLine(demonHealth);
                    Console.WriteLine(playerHealth);
                }
                else if (randomNum < 10 && randomNum > 1)
                {
                    playerHealth = playerHealth - 400;
                        demonHealth = demonHealth + 400;
                    Console.WriteLine ("The demon lets out a howl that burns your brain and sucks the life right out of you, dealing massive amounts of damage and healing for the amount of damage done");
                    Console.WriteLine(demonHealth);

                    Console.WriteLine(playerHealth);
                }
                if (demonHealth <= 0)
                {
                    playing =false;
                    Console.WriteLine("Congratulations you win");
                    Console.WriteLine(demonHealth);
                    Console.WriteLine(playerHealth);

                }
                
                if (playerHealth <= 0)
                {
                                        playing = false;
                    Console.WriteLine("You fail and will rot for eternity");
                    Console.WriteLine(demonHealth);
                    Console.WriteLine(playerHealth);

                }
            }
            


        }
        static void AddHighScore(int playerScore)
        {
            Console.WriteLine("Your name");
            string playerName = Console.ReadLine();
            OwenEntities db = new OwenEntities();
            HighScore newHighScore = new HighScore();
            newHighScore.Game = "DemonSlayerSimulator";
            newHighScore.Name = playerName;
            newHighScore.Score = playerScore;

            //add it to the database
            db.HighScores.Add(newHighScore);

            // save our changes
            db.SaveChanges();

        }
        static void DisplayHighScores()
        {
            //clear console
            Console.Clear();
            //highscore text
            Console.WriteLine("DemonSlayerSimulator High Scores");
            Console.WriteLine("-------------------------------");
            //create new connection to database =]
            OwenEntities db = new OwenEntities();
            // make a list of the high scores
            List<HighScore> highScoreList = db.HighScores.Where(x => x.Game == "DemonSlayerSimulator").OrderByDecending(x >= x.Score).Take(10).ToList();

            foreach (HighScore highScore in highScoreList)
            {
                Console.WriteLine("{0}, {1} - {2} on {3}", highScoreList.IndexOf(highscore) + 1, highscore.Name, highScore.Score);

            }
        }
    }
}
