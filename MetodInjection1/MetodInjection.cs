using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodInjection1
{
    class MetodInjection
    {
        public int Argument { get; set; }
        public int Result { get; set; }

        public void SomeOperation(IOperation operation) // Инъекция через параметр метода
        {
            Result = operation.DoOperation(Argument);
        }

    }
}
