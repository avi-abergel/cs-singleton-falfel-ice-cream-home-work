using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9_singletone_homework
{
    internal class IceCream
    {
        private readonly int _ID;
        public int ID
        {
            get { return _ID; }
        }
        public IceCream(int id, int aBallsNum)
        {
            _ID = id;
            BallsNum=aBallsNum;
        }

        public int BallsNum { get; set; }
    }
}
