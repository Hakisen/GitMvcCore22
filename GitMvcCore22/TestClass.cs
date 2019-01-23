using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GitMvcCore22
{
    public class TestClass
    {   // kommentarer
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public DateTime Orderdate { get; set; }
        public string Category { get; set; }
        public string Shelf { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }

        //Här har Håkan lagt till en kommentar & en prop efter 2:a synken
        public int SoldItems { get; set; }
    }
}
