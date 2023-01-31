using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        /// <summary>
        /// The first name for the vendor.
        /// </summary>
        public string FirstName { get; private set; }
        /// <summary>
        /// The last name for the vendor.
        /// </summary>
        public string LastName { get; private set; }
        /// <summary>
        /// The full name for the vendor.
        /// </summary>
        public string FullName => string.Format("{0} {1}", FirstName, LastName);
            
        /// <summary>
        /// The commision for the vendor that can be changed, it has a default of 0.5.
        /// </summary>
        public double Commision { get; set; } = 0.5;
        /// <summary>
        /// The list of items that the vendor owns.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();
        /// <summary>
        /// Payment owed to the Vendor
        /// </summary>
        public decimal PaymentDue { get; set; } = 0M;
        public string Display => string.Format("{0} - {1:c}", FullName, PaymentDue);
        /// <summary>
        /// The constructor for the vendor.
        /// </summary>
        /// <param name="firstName"> The first name of the vendor</param>
        /// <param name="lastName"> The last name of the vendor </param>
        public Vendor(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        
    }
}
