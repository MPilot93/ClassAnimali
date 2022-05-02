using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animali
{
    public abstract class Animal
    {
        public abstract string Eat();

        public string GetDescription()
        {
            return Eat();
        }
    }
}