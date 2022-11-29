using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace week9_singletone_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager.instance.loadTable();
        }
    }
}
