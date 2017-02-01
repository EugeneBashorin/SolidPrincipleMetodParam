using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodInjection1
{
    class Program
    {
        static void Main(string[] args)
        {
            Increment inc = new Increment();          // Создание зависимости
            MetodInjection mi = new MetodInjection();
            mi.Argument = 10;
            mi.SomeOperation(inc);
            Console.WriteLine(mi.Result);             // Инъекция зависимости через параметр метода
            Console.ReadLine();
        }
    }
}
