using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public int ItemNo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public InvItem()
        {
            ItemNo = 0;
            Description = string.Empty;
            Price = 0m;
        }
        public InvItem(int itemNo, string description, decimal price)
        {
            ItemNo = itemNo;
            Description = description;
            Price = price;
        }
        public string GetDisplayText()
        {
            return $"{ItemNo}    {Description} (${Price:F2})";
        }
    }
}
