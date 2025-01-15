using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ass4
{
    internal class ICirc :ishape
    {
        double radius { get; set; }
        public double area
        {
            get
            {
                return 3.14 * radius *radius ;
            }
        }
        

        public void display()
        {
            Console.WriteLine($"{radius} , {area}" );
        }
    }
}
