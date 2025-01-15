using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec4.InterFace
{
    internal class TypeA : Itype
    {
        private int myAttribute;
        public int Myproperty
        {
            get { return myAttribute; }
            set { myAttribute = value; }
        }

        int Itype.Myproperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Mymethod()
        {
            Console.WriteLine("hello world");
        }
    }
}
