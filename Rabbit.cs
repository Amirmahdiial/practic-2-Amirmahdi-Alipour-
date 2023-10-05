using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_2
{
    class Rabbit : main_animal
    {
        public override void animalSound()
        {
            Console.WriteLine("the rabbit says: och! och!");
        }

        public override void Movement()
        {
            Console.WriteLine("the rabbit jump");
        }

        public override void size()
        {
            Console.WriteLine("the rabbit is small");
        }
    }
}
