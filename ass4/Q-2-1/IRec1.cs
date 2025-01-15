using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass4
{
    internal class IRec1 : ishape
    {
        public double len { get; set; }
        public double wid { get; set; }

        public double area
        {
            get {

                return len * wid;
            }
        }

         public void display()
        {
            Console.WriteLine($"{len} , {area} ,{wid}");
        }
    }
}
