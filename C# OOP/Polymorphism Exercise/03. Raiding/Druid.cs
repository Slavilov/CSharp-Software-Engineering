using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        {
            this.Name= name;
            this.Power = 80;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{this.GetType().Name} - {this.Name} healed for {this.Power}");
        }
    }
}   
