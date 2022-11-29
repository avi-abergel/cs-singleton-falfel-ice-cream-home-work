using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9_singletone_homework
{
    public class Falafel
    {
        private readonly int _ID;

        public int ID
        {
            get { return _ID; }
        }
        public Falafel(int id, int aBallsNum)
        {
            _ID = id;
            BallsNum= aBallsNum;    
        }

        public int BallsNum { get; set; }
    }
}
