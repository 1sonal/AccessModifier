using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.OOPs.AccessModifier
{
    public class ClassA
    {
        //Available only to the container Class 
        private string _privateVariable;

        

        // Available in entire assembly across the classes 
        internal string internalVariable;

        //Available in the container class and the derived class   
        protected string protectedVariable;

        //Available to the container class, entire assembly and to outside    
        public string publicVariable;

        //Available to the derived class and entire assembly as well
        protected internal string protectedInternalVariable;
      //  public ClassA() { }
        public ClassA(string privateVariable, string internalVariable, string protectedVariable, string publicVariable, string protectedInternalVariable)
        {
            _privateVariable = privateVariable;
            this.internalVariable = internalVariable;
            this.protectedVariable = protectedVariable;
            this.publicVariable = publicVariable;
            this.protectedInternalVariable = protectedInternalVariable;
        }

        private string PrivateFunction()
        {
            return _privateVariable;
        }

        internal string InternalFunction()
        {
            return internalVariable;
        }

        protected string ProtectedFunction()
        {
            return protectedVariable;
        }

        public string PublicFunction()
        {
            return publicVariable;
        }

        protected internal string ProtectedInternalFunction()
        {
            return protectedInternalVariable;
        }
    }
}
