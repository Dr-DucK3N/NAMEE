using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random cases = new Random();
            int CPU = cases.Next(1,4);

            Console.WriteLine("Whats your Name??");
            string playername = Console.ReadLine();
            Console.WriteLine("Nice to meetya " + playername + ", I am Ghost,anyways press Enter to continue");
            Console.ReadKey();
            Console.WriteLine(playername+" lets play rock paper scissors");
            Console.ReadKey();
            tryagain:
            Console.WriteLine("type 'ROCK' or 'PAPER' or 'SCISSORS' ");
            string playerentry = Console.ReadLine();


            if (playerentry == ("ROCK"))
            {
                switch (CPU)
                {
                    case 1:
                        Console.WriteLine("Ghost tried using a Scissors, but it got smashed mercilessly");
                        break;
                    case 2:
                        Console.WriteLine("Ghost Covered you ROCK using Paper");
                        break;
                    case 3:
                        Console.WriteLine("Ghost used Rock against your rock but nothing happened");
                        break;
                }
            }

            else if (playerentry == ("PAPER"))
            {
                switch (CPU)
                {
                    case 1:
                        Console.WriteLine("Ghost Used Scissors,to cut through yar PAPERS");
                        break;
                    case 2:
                        Console.WriteLine("Ghost used,Paper Nobody won");
                        break;
                    case 3:
                        Console.WriteLine("Ghost threw a Rock, but it got cover by your PAPERS");
                        break;

                }

            }
            else if (playerentry == ("SCISSORS")) {
                switch (CPU)
                {
                    case 1:
                        Console.WriteLine("Ghost Tried to use PAPERs,*but failed miserably against your SCISSORS*");
                        break;
                    case 2:
                        Console.WriteLine("Ghost Threw a ROCK at ya,*and a successful hit*");
                            break;
                    case 3:
                        Console.WriteLine("Ghost used SCISSORS & nobody lost");
                        break;
                }


            }

            else {
                Console.WriteLine("Ghost can only read CAPITAL LETTERS, So pls type in upper case <press enter to continue>");
                
                Console.ReadKey();
                goto tryagain;

            }

            Console.WriteLine("type 'RESTART' to Restart or type anything else  to quit");
            String AB= Convert.ToString(Console.ReadLine());

            if(AB == ("RESTART"))
            {
                goto tryagain;
            }

            else
            {
                Console.WriteLine("BUT Ghost wanted to play more <press any key again to quit>");
                Console.ReadKey();
            }


         


        }
    }
}
