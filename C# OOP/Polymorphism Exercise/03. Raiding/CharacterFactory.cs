using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class CharacterFactory
    {
        public static BaseHero getHero(string name, string type)
        {
            BaseHero ObjectType = null;
            if (type == "Druid")
            {
                ObjectType = new Druid(name);
            }
            else if (type == "Paladin")
            {
                ObjectType = new Paladin(name);
            }
            else if (type == "Rogue")
            {
                ObjectType = new Rogue(name);
            }
            else if (type == "Warrior")
            {
                ObjectType = new Warrior(name);
            }

            return ObjectType;
        }
    }
}
