using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.OOPs.AccessModifier
{
    public class ClassB
    {
      
        static void Main(String[] args)
        {
           
            // private and protected members cant be accessed
            ClassA obj = new ClassA("Hello", "World", "C#", "Access","Modifier");
            String InternalVariable=obj.internalVariable;
            String PublicVariable=obj.publicVariable;
            String ProtectedVariable=obj.protectedInternalVariable;
            Console.WriteLine("InternalVariable,PublicVariable,ProtectedInternalVariable are {0},{1},{2}", InternalVariable, PublicVariable, ProtectedVariable);
            
        }
    }
}
