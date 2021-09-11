using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_game
{
    public class Ball : MainGame
    {
        public char ball { get; set; } = '*';



        public bool[,] BallCreator(bool[,] Determineplaceofall,ref int points)
        {

            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Random rand = new Random();
            int x = rand.Next(1, 79);
            int y = rand.Next(1, 24);
            Console.SetCursorPosition(x, y);
            Console.Write(ball);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            try
            {
                while (Determineplaceofall[x, y] == false)
                {

                    ConsoleKeyInfo MovetMovet = Console.ReadKey();
                    switch (MovetMovet.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Console.SetCursorPosition(x, y);
                            Determineplaceofall[x, y] = true;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            y--;
                            Console.Write('*');
                            break;
                        case ConsoleKey.DownArrow:
                            Console.SetCursorPosition(x, y);
                            Determineplaceofall[x, y] = true;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            y++;
                            Console.Write('*');
                            break;
                        case ConsoleKey.LeftArrow:
                            Console.SetCursorPosition(x, y);
                            Determineplaceofall[x, y] = true;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            x--;
                            Console.Write('*');
                            break;
                        case ConsoleKey.RightArrow:
                            Console.SetCursorPosition(x, y);
                            Determineplaceofall[x, y] = true;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            x++;
                            Console.Write('*');
                            break;

                    }

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(x, y);
                    points++;

                    Console.Write(ball);


                }
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Black;
                return Determineplaceofall;

            }

            Console.BackgroundColor = ConsoleColor.Black;

            return Determineplaceofall;
        }


    }



}












