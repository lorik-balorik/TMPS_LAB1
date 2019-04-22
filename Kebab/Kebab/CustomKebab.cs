using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class StarKebabKing : Kebab
    {
        IComponentsFactory componentsFactory;

        public StarKebabKing(IComponentsFactory _componentsFactory)
        {
            componentsFactory = _componentsFactory;
            name = "Star Kebab King";
            dough = "Thin Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Ham");
        }

        public override void Prepare()
        {
            Console.WriteLine("Making custom kebab");
            componentsFactory.createDough();
            componentsFactory.createSauce();
            componentsFactory.createMeat();
        }

        public override void Cut()
        {
            Console.WriteLine("Cut into slices");
        }

        public override Kebab Clone()
        {
            Console.WriteLine("-----------CLONE KEBAB-----------");
            return  this.MemberwiseClone() as Kebab;
        }
    }

    class StarKebabHot : Kebab
    {
        IComponentsFactory componentsFactory;

        public StarKebabHot(IComponentsFactory _componentsFactory)
        {
            componentsFactory = _componentsFactory;
            name = "Star Kebab Hot";
            dough = "Thin Dough";
            sauce = "Bruschetta Sauce";
            toppings.Add("Reggiano cheese");
            toppings.Add("Garlic");
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Star Kebab Hot kebab at Star Kebab");
            componentsFactory.createDough();
            componentsFactory.createSauce();
            componentsFactory.createMeat();
        }

        public override void Cut()
        {
            Console.WriteLine("Cut into slices");
        }

        public override Kebab Clone()
        {
            return this.MemberwiseClone() as Kebab;
        }


    }

    class FastKebabSmall : Kebab
    {
        IComponentsFactory componentsFactory;

        public FastKebabSmall(IComponentsFactory _componentsFactory)
        {
            componentsFactory = _componentsFactory;
            name = "Fast Kebab Small kebab";
            dough = "Thick Dough";
            sauce = "Plum Sauce";
            toppings.Add("Pickled Onion");
            toppings.Add("Tomato");
        }

        public override Kebab Clone()
        {
            return this.MemberwiseClone() as Kebab;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing Fast Kebab Small kebab at Fast Kebab");
            componentsFactory.createDough();
            componentsFactory.createSauce();
            componentsFactory.createMeat();
        }

        public override void Bake()
        {
            Console.WriteLine("Cook 20 minutes on fire!");
        }
    }
}
