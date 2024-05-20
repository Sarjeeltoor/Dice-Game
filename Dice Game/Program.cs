using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int playerPoints = 0;
            int enemyRandomNum;
            int enemyPoints = 0;
            Random random = new Random();
            for(int i = 0; i < 10;i++ )
            {
            Console.WriteLine("Press any key to role the dice");
            Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);
               
                
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy rolled a " + enemyRandomNum);
                
                if(playerRandomNum > enemyRandomNum )
                {
                    playerPoints++;
                    Console.WriteLine("player wins this round");
                }else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine("The Score is now player :" + playerPoints + " Enemy "  +   enemyPoints + ".");
                Console.WriteLine();
            }
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("player wins this round");
            }else if
                (playerPoints < enemyPoints){
                Console.WriteLine("you loose this round");
            }
            else
            {
                Console.WriteLine("Scores are level Match Draw");
            }
            Console.WriteLine("Thanks for playing this game.");
            Console.ReadKey();
        }
    }
}
