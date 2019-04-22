using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    public interface IComponentsFactory
    {
        Dough createDough();
        Sauce createSauce();
        Meat createMeat();
    }

    public class Dough
    {

    }

    public class Sauce
    {

    }

    public class Meat
    {

    }


    public class StarKebabComponentsFactory : IComponentsFactory
    {
        public Meat createMeat()
        {
            Console.WriteLine("Create Star Kebab Meat");
            return new Meat();
        }

        public Dough createDough()
        {
            Console.WriteLine("Create Star Kebab Dough");
            return new Dough();
        }

        public Sauce createSauce()
        {
            Console.WriteLine("Create Star Kebab Sauce");
            return new Sauce();
        }

    }

    public class FastKebabComponentsFactory : IComponentsFactory
    {
        public Meat createMeat()
        {
            Console.WriteLine("Create Fast Kebab Meat");
            return new Meat();
        }

        public Dough createDough()
        {
            Console.WriteLine("Create Fast Kebab Dough");
            return new Dough();
        }

        public Sauce createSauce()
        {
            Console.WriteLine("Create Fast Kebab Sauce");
            return new Sauce();
        }
    }
}
