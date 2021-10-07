using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.OOPs.AccessModifier
{
    class ClassC : ClassD
    {
        public int num1;
        static void Main(String[] args)
        {
            ClassC obj1 = new ClassC();
            obj1.num1 = 44;
            Console.WriteLine("Protected number=" + obj1.num1);
             
          
        }
    }
}
