using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoeStore
{
    public class ShoeStore
    {
        public ShoeStore(string name, int capacity)
        {
            this.Name = name;
            this.StorageCapacity = capacity;
            shoes = new List<Shoe>();

            //shoes = new List<Shoe>();
        }

        //private List<Shoe> Shoes;
        //public List<Shoe> Shoes
        //{
        //    get { return shoes; }
        //    private set { shoes = value; }
        //}


        private string name;
        private int storageCapacity;
        private List<Shoe> shoes;

        public List<Shoe> Shoes
        {
            get { return shoes; }
           private set { shoes = value; }
        }


        public string Name
        {
            get { return name; }
           private set { name = value; }
        }

        public int StorageCapacity
        {
            get { return storageCapacity; }
            set { storageCapacity = value; }
        }

        public int Count
        {
            get
            {
                return this.shoes.Count();
            }
        }

        public string AddShoe(Shoe shoe)
        {
            if (this.shoes.Count < this.storageCapacity )
            {
                shoes.Add(shoe);
                return $"Successfully added {shoe.Type} {shoe.Material} pair of shoes to the store.";
            }
            else
            {
                return "No more space in the storage room.";
            }
        }

        public int RemoveShoes(string material)
        {
            //int removedCount = 0;
            //int counter = -1;
            //
            //foreach (var shoe in this.shoes.ToList())
            //{
            //    counter++;
            //
            //    if (shoe.Material == material)
            //    {
            //        this.shoes.RemoveAt(counter);
            //        removedCount++;
            //        counter--;
            //    }
            //}

            int removedElements = this.shoes.RemoveAll(x => x.Material == "material");

            return removedElements;

            //return removedCount;
        }

        public List<Shoe> GetShoesByType(string type)
        {
            List<Shoe> result = new List<Shoe>();

            type = type.ToLower();

            foreach (var shoe in this.shoes)
            {
                if (shoe.Type.ToLower().Contains(type))
                {
                    result.Add(shoe);
                }
            }
            return result;
        }
        public Shoe GetShoeBySize(double size)
        {
            //foreach (Shoe shoe in shoes)
            //{
            //    if (shoe.Size == size)
            //    {
            //        return shoe;
            //    }
            //}
            //return null;

           //var first = this.shoes.FirstOrDefault(x => x.Equals(size));
           // return first;

            var second = this.shoes.FirstOrDefault(shoes => shoes.Size == size);
            return second;
        }



        //public string StockList(double size, string type)
        //{
        //    List<Shoe> matches = new List<Shoe>();
        //
        //    // Use ToLower() to make the search case-insensitive
        //    type = type.ToLower();
        //
        //    foreach (Shoe shoe in shoes)
        //    {
        //        if (shoe.Size == size && shoe.Type.ToLower().Contains(type))
        //        {
        //            matches.Add(shoe);
        //        }
        //    }
        //
        //    // Build the result string
        //    if (matches.Count == 0)
        //    {
        //        // If no matches were found, return the "no matches" message
        //        return "No matches found!";
        //    }
        //    else
        //    {
        //        // If matches were found, build the report string
        //        StringBuilder sb = new StringBuilder();
        //        sb.Append("Stock list for size " + size + " - " + type + " shoes:\n");
        //        foreach (Shoe shoe in matches)
        //        {
        //            sb.Append(shoe + "\n");
        //        }
        //        return sb.ToString();
        //    }
        //}

        public string StockList(double size, string type)
        {
            StringBuilder sb = new StringBuilder();

            if (shoes.Any(x => x.Size == size && x.Type == type))
            {
                sb.AppendLine($"Stock list for size {size} - {type} shoes:");

                var matchingShoes = shoes.Where(x => x.Size == size && x.Type == type).ToList();

                foreach (var shoe in matchingShoes)
                {
                    sb.AppendLine(shoe.ToString());
                }

                return sb.ToString().Trim();
            }
            else
            {
                string noMatches = "No matches found!";
                return noMatches;

            }

        }
    }
}
