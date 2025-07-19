using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    internal interface ITypeA
    {
        void Print();
        public int Y { get; set; }

        void PrintHello()
        {
            Console.WriteLine("SayHello");
        }
}
