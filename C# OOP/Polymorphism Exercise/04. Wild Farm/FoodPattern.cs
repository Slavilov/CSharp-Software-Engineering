using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildFarm
{
    public class FoodPattern
    {
        public static Food getFood(string type, int quantity)
        {
            Food ObjectType = null;
            if (type == "Fruit")
            {
                ObjectType = new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                ObjectType = new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                ObjectType = new Seeds(quantity);
            }
            else if (type == "Vegetable")
            {
                ObjectType = new Vegetable(quantity);
            }

            return ObjectType;
        }
    }
}
