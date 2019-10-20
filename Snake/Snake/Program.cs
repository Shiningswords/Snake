using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 4;
            p1.y = 16;
            p1.symb = 'X';
            p1.Draw();
            Console.ReadKey();
        }
    }
}
