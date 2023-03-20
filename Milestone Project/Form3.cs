using System;
using System.Collections;
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
    public partial class Restock : Form
    {
        //Initiales the bookstore, inventory manager, and the inventory struct
        BookStore bookStore;
        Inventory.inventoryStruct inventoryRestock = new Inventory.inventoryStruct();
        public Restock(BookStore bookStore)
        {
            this.bookStore = bookStore;
            InitializeComponent();
        }

        private void restockBtn_Click(object sender, EventArgs e)
        {
            if(int.TryParse(restockTxt.Text, out int additional))
            {
                //Fills in the inventoryRestock struct with existing item information.   
                inventoryRestock.title = bookStore.resultsLst.SelectedItems[0].SubItems[0].Text;
                inventoryRestock.genre = bookStore.resultsLst.SelectedItems[0].SubItems[1].Text.Split(',');
                //Adds the additional quantity of books to the exisitng quantity of books.
                if (int.TryParse(bookStore.resultsLst.SelectedItems[0].SubItems[2].Text, out int quantity)) { inventoryRestock.quantity = quantity + additional; }
                if (int.TryParse(bookStore.resultsLst.SelectedItems[0].SubItems[3].Text, out int price)) { inventoryRestock.price = price; }
                if (int.TryParse(bookStore.resultsLst.SelectedItems[0].SubItems[4].Text, out int pages)) { inventoryRestock.pageCount = pages; }
                inventoryRestock.productID = int.Parse(bookStore.resultsLst.SelectedItems[0].SubItems[5].Text);
                
                //Replaces the existing inventory array with the restocked inventory item and displays the new quantity
                bookStore.inventoryItems = bookStore.inventoryManager.edit(inventoryRestock);
                bookStore.showInventory(bookStore.inventoryItems);
                //Closes out the form.
                this.Close();
            }
        }
    }
}
