using FGame.Model.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FGame.Controller
{
    public class GameBoardLogic
    {
        public static void MakeSpawn()
        {
            var mySpawn = GetPoint(0, 42, 0, 24);
            var opponentSpawn = GetPoint(42, 85, 24, 48);

        }

        private static Vector2 GetPoint(int x0, int x1, int y0, int y1)
        {
            var rnd = new Random();
            return new Vector2(rnd.Next(x0 + 4, x1 - 4), rnd.Next(y0 + 4, y1 - 4));
        }

        //private static void MakeHalfZone(Block[,] blocks, Vector2 point, int a)
        //{
        //    for (var i = 6; i >= 0; i--)
        //    {
        //        if (0 < point.Y + a * i || point.Y + a * i > 84) continue;
        //        for(var j = 6; j - i >= 0; j--)
        //        {
        //            if (j - i == 0)
        //            {
        //                blocks[(int)point.Y + a * i, (int)point.X]
        //            }
        //        }

        //    }
        //}
    }
}
