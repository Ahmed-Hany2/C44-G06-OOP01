using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    internal struct StructA : ITypeA
    {
        void ITypeA.Print()
        {
            Console.WriteLine("Print StructA");
        }
    }
}
