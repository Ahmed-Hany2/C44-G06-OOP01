using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Demo.UserDefinedDataTypes
{
    internal class ClassA : ITypeA
    {
        protected int X;
       
        public int Y { get; set; }

        void ITypeA.Print()
        {
            Console.WriteLine("Print ClassA");
        }

    }
}
