using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace week9_singletone_homework
{
    public class Manager
    {
        private Manager() { }
        private static Manager _instance;

        public static Manager instance
        {
            get 
            {
                if (_instance==null)
                {
                    _instance = new Manager();
                }
                return _instance;
            }
        }

        Hashtable tbl=new Hashtable(9999);
        Random r = new Random();
        public void loadTable()
        {
            for (int i = 1; i <= 1000; i++)
            {
                int num = r.Next(100, 9999);
                if (num % 2 == 0)
                {
                    if (!tbl.ContainsKey(num))
                    {
                        tbl.Add(num, new Falafel(num, r.Next(1, 5)));
                    }
                }
                else
                {
                    if (!tbl.ContainsKey(num))
                    {
                        tbl.Add(num, new IceCream(num, r.Next(1, 5)));
                    }
                }
            }

                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine("please enter a key between 100 and 9999");
                    int key =int.Parse(Console.ReadLine());
                    if (tbl.ContainsKey(key))
                    {
                        if (tbl[key] is Falafel)
                        { 
                            Falafel f=(Falafel)tbl[key];
                            Console.WriteLine($"this falafel has {f.BallsNum} balls");
                            Console.ReadLine();
                        }
                        else if (tbl[key] is IceCream){
                            IceCream ic=(IceCream)tbl[key];
                            Console.WriteLine($"this icecream has {ic.BallsNum} balls");
                            Console.ReadLine();
                        }
                    }
                }
            
        }
       

    }
}
