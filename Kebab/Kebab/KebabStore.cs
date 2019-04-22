using System;

namespace Kebab
{
    public abstract class KebabStore
    {
        
        public Kebab OrderKebab(String type)
        {
            var kebab = CreateKebab(type);
            kebab.Prepare();
            kebab.Bake();
            kebab.Cut();
            kebab.Box();
            return kebab;
        }

        //It has the responsability for creating the kebab
        protected abstract Kebab CreateKebab(String type);
    }

    public class StarKebabStore : KebabStore
    {
        protected override Kebab CreateKebab(string type)
        {
            Kebab kebab = null;
            IComponentsFactory componentsFactory = new StarKebabComponentsFactory();

            if (type == "Garlic")
                kebab = new StarKebabKing(componentsFactory);
            else if (type == "Ketchup")
                kebab = new StarKebabHot(componentsFactory);

            return kebab;
        }
    }

    public class FastKebabStore : KebabStore
    {
        protected override Kebab CreateKebab(string type)
        {
            Kebab kebab = null;
            IComponentsFactory componentsFactory = new FastKebabComponentsFactory();

            if (type == "Garlic")
                kebab = new FastKebabSmall(componentsFactory);

            return kebab;
        }


    }
}
