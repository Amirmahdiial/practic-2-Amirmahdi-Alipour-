using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic_2
{
    class  cow : main_animal
    {
        public override void animalSound()
        {
            Console.WriteLine("the cow says:moo! moo!");
        }

        public override void Movement()
        {
            Console.WriteLine("the cow walk");
        }

        public override void size()
        {
            Console.WriteLine("the cow is big");
        }
        
    }
}
