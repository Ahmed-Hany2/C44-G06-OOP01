using Demo.UserDefinedDataTypes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UserDefinedDataTypes
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
       public Gender gender { get; set; }
        public Grade Grade { get; set; }
        public Branch Branch { get; set; }

    }
}
