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
            if (IsValidData())
            {
                invItem = new InvItem(
                    Convert.ToInt32(txtItemNo.Text),
                    txtDescription.Text,
                    Convert.ToDecimal(txtPrice));
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

        //closes form
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
