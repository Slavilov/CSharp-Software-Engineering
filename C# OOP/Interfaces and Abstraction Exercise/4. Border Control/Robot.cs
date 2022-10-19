using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Robot : INameAndId
    {
        public Robot(string model, string id)
        {
            this.Name = model;
            this.Id = id;
        }

        public string Name { get ; set ; }
        public string Id { get ; set ; }
    }
}
