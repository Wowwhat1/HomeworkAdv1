using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_9_1.Dice
{
    internal class Dice
    {
        // Field
        private int _side;
        // Property
        public int Side
        {
            get { return _side; }
            set { if (_side > 0) _side = value; }
        }

        public int Roll()
        {
            Random rd = new Random();
            return rd.Next(1, _side + 1);
        }
    }
}
