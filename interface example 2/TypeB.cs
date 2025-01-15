using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec4.interface_example_2
{
    internal class TypeB : Iseries
    {
        public int Current { get ; set  ; }

        public void GetNext()
        {
            Current += 3;
        }

        public void reset()
        {
            Current = 0;
        }
    }
}
