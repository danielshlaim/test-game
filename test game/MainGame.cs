using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_game
{
    public class MainGame
    {

        List<IShapeOfChar> listofshape { get; set; } = new List<IShapeOfChar>();
        List<IShapeOfChar> gamelistshape = new List<IShapeOfChar>(15);
        public int shapecounter { get; set; }
        public Random random { get; set; } = new Random();
        public bool[,] Determineplaceofall { get; set; } = new bool[81, 26];
        public int Until30 { get; set; } = 0;
        public bool CheckIfSuccseed { get; set; }
        


        public MainGame()
        {
            listofshape.Add(new Lines());
            listofshape.Add(new Square());
            listofshape.Add(new Triangular());
            listofshape.Add(new Rectangle());
            shapecounter = random.Next(3, 6);

        }


        public void StartGame()
        {
            Console.SetWindowSize(81, 26);
            int points = 0;

            while (shapecounter != 15 && Until30 != 30)
            {
                Console.Clear();
                Determineplaceofall.clean(); // מנקה את המערך הכללי
                Console.BackgroundColor = ConsoleColor.Black;
                for (int i = 0; i < shapecounter; i++)
                {
                    int randomshape = random.Next(0, 3);
                    gamelistshape.Add(listofshape[randomshape]);

                }
                foreach (var item in gamelistshape)
                {
                    item.Shape();
                    CheckIfSuccseed = TrueOrFalse(item.iftouchyoufail, Determineplaceofall);
                    if (CheckIfSuccseed == false)
                    {
                        Determineplaceofall.clean();
                        gamelistshape.Clear();
                        Until30++;
                        break;
                    }
                }
                if (CheckIfSuccseed == true)
                {
                    Ball ball = new Ball();
                    Determineplaceofall = ball.BallCreator(Determineplaceofall,ref points);
                    shapecounter++;
                }
                Console.Clear();
            }
            if (shapecounter == 15 || Until30 == 30)
            {
                Console.WriteLine($"Congratulations! you Win {points} points");
            }
       
        
        } 
        public bool TrueOrFalse(bool [,]T ,  bool[,] T1)
        {
            for (int i = 0; i < T.GetLength(0); i++)
            {
                for (int j = 0; j < T.GetLength(1); j++)
                {
                    if (T[i, j] == true && T1[i, j] == false)
                    {

                        T1[i, j] = true;

                    }
                    else if (T[i, j] == true && T1[i, j] == true) return false;
                }
            }
            return true;
        }

       
        
    }
}
