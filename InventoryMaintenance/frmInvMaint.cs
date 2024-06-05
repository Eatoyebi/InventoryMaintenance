using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
            //Text property change
            this.Text = "Liz Atoyebi's Inventory Maintenance Application";
        }

        //declares the list of items.
        private List<InvItem> invItems = null;
        //loads form and retrieves list of items
        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        //fills list w/ item details
        private void FillItemListBox()
        {
            lstItems.Items.Clear();
            foreach (InvItem item in invItems)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        // Liz Atoyebi
        //Opens New Item form to add new item
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem newItem = newItemForm.GetNewItem();
            if (newItem != null)
            {
                invItems.Add(newItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }
        // Liz Atoyebi
        //Deletes selected items from list
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    invItems.RemoveAt(i);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }
        //Closes the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
