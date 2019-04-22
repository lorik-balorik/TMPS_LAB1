using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    public abstract class Kebab 
    {
        public  String name;
        public  String dough;
        public  String sauce;
        public ArrayList toppings = new ArrayList();


        public abstract void Prepare();


        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");

        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the kebab into diagonal slices");

        }

        public virtual void Box()
        {
            Console.WriteLine("Place kebab in official KebabStore box");
        }

        public string GetName()
        {
            return name;
        }

        public abstract Kebab Clone();

    }
}
