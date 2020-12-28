using System;
using System.Collections.Generic;
using System.Text;

namespace PaternsHomework
{
    public class Tractor : Car
    {
        public override void Break()
        {
            Console.WriteLine("Упс сломался");
        }

        public override void Go()
        {
            Console.WriteLine("Чучух ту ту");
        }
    }
}
