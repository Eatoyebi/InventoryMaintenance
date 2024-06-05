using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {
        public frmNewItem()
        {
            InitializeComponent();
        }
        //inventory
        private InvItem invItem = null;

        //Liz Atoyebi, gets and returns new item
        public InvItem GetNewItem()
        {
            this.ShowDialog();
            return invItem;
        }
        //Liz Atoyebi, saves item and closes form
        private void btnSave_Click(object sender, EventArgs e)
        {
            int itemNo;
            decimal price;

            if (IsValidData() && int.TryParse(txtItemNo.Text, out itemNo) && decimal.TryParse(txtPrice.Text, out price))
            {
                invItem = new InvItem(
                    itemNo,
                    txtDescription.Text,
                    price);
                this.Close();
            }
        }

        //validates input
        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
