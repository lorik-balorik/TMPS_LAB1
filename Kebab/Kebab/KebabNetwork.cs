using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kebab
{
    public interface IKebabNetwork
    {
        StarKebabStore GetStarKebabStore();
        FastKebabStore GetFastKebabStore();
    }

    public class KebabNetwork : IKebabNetwork
    {
        public StarKebabStore GetStarKebabStore() =>new StarKebabStore();

        FastKebabStore IKebabNetwork.GetFastKebabStore() => new FastKebabStore();


    }
}
