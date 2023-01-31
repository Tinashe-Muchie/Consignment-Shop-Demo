using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Item
    {
        /// <summary>
        /// The title of an item.
        /// </summary>
        public string Title { get; private set; }
        /// <summary>
        /// The description of an item.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// The price of an item.
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// The status of whether an item is sold or still available.
        /// </summary>
        public bool Sold { get; set; } = false;
        /// <summary>
        /// The owner of the item.
        /// </summary>
        public Vendor Owner { get; set; }

        public string Display => string.Format("{0} - {1:c}", Title, Price); 

        public Item(string title, string description)
        {
            Title = title;
            Description = description;
        }
        /// <summary>
        /// Override the Item class ToString method.
        /// </summary>
        /// <returns> returns a string of the title </returns>
        public override string ToString() => Title;
    }
}
