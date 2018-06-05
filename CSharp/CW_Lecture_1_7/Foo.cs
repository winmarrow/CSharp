using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_1_7
{
    class Foo
    {
        int counter = 10;

        public const string DefaultName = "Some Default Name";
        public readonly int SomeDefaultValue = 11;


        public readonly Guid ID = Guid.NewGuid();
    }
}
