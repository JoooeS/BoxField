using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxField
{
    class Player
    {
        public int size, x1, y1, x2, y2, x3, y3;

        /// <summary>
        /// gdfgodfjg
        /// </summary>
        /// <param name="_size"></param>
        /// <param name="_x1"></param>
        /// <param name="_y1"></param>
        /// <param name="_x2"></param>
        /// <param name="_y2"></param>
        /// <param name="_x3"></param>
        /// <param name="_y3"></param>
        public Player (int _size, int _x1, int _y1, int _x2, int _y2, int _x3, int _y3)
        {
            size = _size;
            x1 = _x1;
            y1 = _y1;

            x2 = _x2;
            y2 = _y2;

            x3 = _x3;
            y3 = _y3;
        }
    }
}
