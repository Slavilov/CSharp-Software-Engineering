using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
            this.Name = name;
            this.Power = 100;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{this.GetType().Name} - {this.Name} hit for {this.Power}");
        }
    }
}
