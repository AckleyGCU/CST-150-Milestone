using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project
{
    public partial class UpdateInventory : Form
    {
        //Initiales the bookstore, inventory manager, and the inventory struct
        BookStore bookStore;
        public UpdateInventory(BookStore bookStore, string confirmBtnText)
        {
            this.bookStore = bookStore;
            InitializeComponent();
            confirmBtn.Text = confirmBtnText;
        }

        public UpdateInventory(BookStore bookStore, string confirmBtnText, string[] currentValue)
        {
            this.bookStore = bookStore;
            InitializeComponent();
            confirmBtn.Text = confirmBtnText;
            addTitle.Text = currentValue[0];
            addQuantity.Text = currentValue[1];
            addPrice.Text = currentValue[2];
            addPageCount.Text = currentValue[3];
        }

        private void addEditChanged(object sender, EventArgs e)
        {
            if (addTitle.Text != "" && addQuantity.Text != "" && addPrice.Text != "" && addPageCount.Text != "" && genreBox.SelectedIndices.Count > 0)
            {
                confirmBtn.Enabled = true;
            }
            else
            {
                confirmBtn.Enabled = false;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Inventory.inventoryStruct inventoryUpdate = new Inventory.inventoryStruct();
            inventoryUpdate.title = addTitle.Text;
            if (int.TryParse(addPrice.Text, out int price)) { inventoryUpdate.price = price; }
            if (int.TryParse(addQuantity.Text, out int quantity)) { inventoryUpdate.quantity = quantity; }
            if (int.TryParse(addPageCount.Text, out int pages)) { inventoryUpdate.pageCount = pages; }

            string[] genre = new string[genreBox.SelectedItems.Count];
            genreBox.SelectedItems.CopyTo(genre, 0);
            inventoryUpdate.genre = genre;

            if (confirmBtn.Text.Equals("Add Book"))
            {
                inventoryUpdate.productID = bookStore.inventoryItems.Count;
                //Replaces the existing inventory array with the updated inventory
                bookStore.inventoryItems = bookStore.inventoryManager.add(inventoryUpdate);
            }
            else if (confirmBtn.Text.Equals("Edit Book"))
            {
                inventoryUpdate.productID = int.Parse(bookStore.resultsLst.SelectedItems[0].SubItems[5].Text);

                //Replaces the existing inventory array with the updated inventory
                bookStore.inventoryItems = bookStore.inventoryManager.edit(inventoryUpdate);
            }
            //Repopulates the displayed inventory with correct information.
            bookStore.showInventory(bookStore.inventoryItems);

            this.Close();
        }
    }
}
