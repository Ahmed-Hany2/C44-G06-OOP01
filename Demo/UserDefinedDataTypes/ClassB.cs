using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    internal class ClassB : ClassA
    {
        public ClassB()
        {
            Y = 10;
            X = 20; // protected member from ClassA
        }
    }
}
