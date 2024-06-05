using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    // Liz Atoyebi: inventory itrm - demonstrates encapsulation by encapsulating the properties of an inventory item and providing methods to access them.
    public class InvItem
    {
        //properties
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        // Liz Atoyebi; default constructor - initializes the properties of the InvItem class to default values
        public InvItem()
        {
            ItemNo = 0;
            Description = string.Empty;
            Price = 0m;
        }

        //Liz Atoyebi: parameterized constructor - initializes the properties of the InvItem class with the provided values
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }

        //Returns formatted item details
        // Liz Atoyebi: returns a formatted string containing the details of the inventory item
        public string GetDisplayText()
        {
            return $"{ItemNo}    {Description} (${Price:F2})";
        }
    }
}
