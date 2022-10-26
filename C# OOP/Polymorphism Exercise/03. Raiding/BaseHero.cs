using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }

        public string Name { get; private protected set; }
        public int Power { get; private protected set; }

        public abstract void CastAbility();

    }
}
