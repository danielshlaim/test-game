using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_game
{
    public static class CleanExtesion
    {
        public static  bool[,] clean( this bool[,] clear)
        {
            for (int i = 0; i < clear.GetLength(0); i++)
            {
                for (int j = 0; j < clear.GetLength(1); j++)
                {
                    clear[i, j] = false;
                }
            }
            return clear;
        }

    }
}
