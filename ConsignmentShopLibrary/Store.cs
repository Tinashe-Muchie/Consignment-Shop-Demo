using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        /// <summary>
        /// The name of the store.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// The list of the Vendors that have items in the store.
        /// </summary>
        public List<Vendor> Vendors { get; set; } = new List<Vendor>();
        /// <summary>
        /// The list of items that are in the store.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        public decimal Profit { get; set; }

        public Store(string name)
        {
            Name = name;
        }
    }
}
