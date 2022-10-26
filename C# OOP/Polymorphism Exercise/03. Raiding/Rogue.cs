using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        {
            this.Name = name;
            this.Power = 80;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{this.GetType().Name} - {this.Name} hit for {this.Power}");
        }
    }
}
