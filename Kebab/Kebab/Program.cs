using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    class Program
    {
        static void Main(string[] args)
        {
            var StarKebabStore = Franchise.Instance.KebabNetwork.GetStarKebabStore();
            var FastKebabStore = Franchise.Instance.KebabNetwork.GetFastKebabStore();
            Console.WriteLine("--------------------------------------------");
            var a = StarKebabStore.OrderKebab("Ketchup");
            Console.WriteLine("--------------------------------------------");
            var b = FastKebabStore.OrderKebab("Garlic");
            Console.WriteLine("--------------------------------------------");
            var c = StarKebabStore.OrderKebab("Garlic");

            var clonedKebabList = new List<Kebab>()
            {
                a.Clone(),
                b.Clone(),
                c.Clone()
            };

            foreach (var kebab in clonedKebabList)
                Console.WriteLine(kebab.GetName());
            
            Console.ReadKey();
        }
    }
}
