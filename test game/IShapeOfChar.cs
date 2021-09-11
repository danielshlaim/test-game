using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_game
{
    public interface IShapeOfChar
    {
        public Random random { get; set; }
        public void Shape();
        public bool[,] iftouchyoufail { get; set; }
    }
    public class Lines : IShapeOfChar
    {
        public Random random { get; set; } = new Random();
        public char TheChar { get; set; } = '=';
        public bool[,] iftouchyoufail { get; set; } = new bool[81, 26];
        

        public void Shape()
        {
            iftouchyoufail.clean();
           // Random random = new Random();
            int locationx = random.Next(1, 79);
            int locationy = random.Next(1, 24);

            int z = random.Next(2, 10);
            Console.SetCursorPosition(locationx, locationy);
            Console.ForegroundColor = (ConsoleColor)random.Next(1,14);
            for (int i = 0; i < z; i++)
            {
                if (locationx + i >= 80 || locationy >= 25)
                {
                   
                    break;
                }

                Console.Write(TheChar);
                iftouchyoufail[locationx + i, locationy] = true;
            }

        }
    }

    public class Triangular : IShapeOfChar
    {
        public Random random { get; set; } = new Random();
        public char TheChar { get; set; } = '^';
        public bool[,] iftouchyoufail { get; set; } = new bool[81, 26];

        public void Shape()
        {
            iftouchyoufail.clean();
            //Random random = new Random();
            int locationx = random.Next(1, 79);
            int locationy = random.Next(1, 24);

            int z = random.Next(2, 9);
            Console.SetCursorPosition(locationx, locationy);
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 14);
            for (int i = 0; i < z; i++)
            {
                Console.SetCursorPosition(locationx, locationy + i);
                for (int j = 0; j <= i; j++)
                {
                    if (locationx + j >= 80 || locationy +i >= 25)
                    {
                        locationx = locationx + j;
                        break;
                    }
                    Console.Write(TheChar);
                    iftouchyoufail[locationx + j, locationy + i] = true;
                }
                if (locationx >= 80 || locationy +i >= 25)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }


    public class Rectangle : IShapeOfChar
    {
        public Random random { get; set; } = new Random();
        public char TheChar { get; set; } = '^';
        public bool[,] iftouchyoufail { get; set; } = new bool[81, 26];

        public void Shape()
        {
            iftouchyoufail.clean();
            //Random random = new Random();
            int locationx = random.Next(1, 79);
            int locationy = random.Next(1, 24);


            int x = random.Next(2, 10);
            int y = random.Next(3, 10);
            Console.SetCursorPosition(locationx, locationy);
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 14);
            for (int i = 0; i < x; i++)
            {
               Console.SetCursorPosition(locationx, locationy + i);
                for (int j = 0; j < y; j++)
                {
                    if (locationx + j >= 80 || locationy+i >= 25)
                    {
                        break;
                    }
                    Console.SetCursorPosition(locationx + i, locationy + j);
                    Console.Write(TheChar);
                    iftouchyoufail[locationx + j, locationy + i] = true;
                }
                if (locationx >= 80 || locationy+i >= 25)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }

    public class Square : IShapeOfChar
    {
        public Random random { get; set; } = new Random();
        public char TheChar { get; set; } = '^';
        public bool[,] iftouchyoufail { get; set; } = new bool[81, 26];

        public void Shape()
        {
            iftouchyoufail.clean();
            //Random random = new Random();
            int locationx = random.Next(1, 79);
            int locationy = random.Next(1, 24);

            int squareshape = random.Next(3, 10);
            Console.ForegroundColor = (ConsoleColor)random.Next(1, 14);
            for (int i = 0; i < squareshape; i++)
            {
                Console.SetCursorPosition(locationx, locationy + i);
                for (int j = 0; j < squareshape; j++)
                {
                    
                    if (locationx + j >= 80|| locationy+i >= 25)
                    {
                        break;
                    }
                    Console.Write(TheChar);
                    iftouchyoufail[locationx + j, locationy + i] = true;

                }
                if (locationx >= 80 || locationy+i >=25)
                {
                    break;
                }
                Console.WriteLine();


            }
        }

    }

}
