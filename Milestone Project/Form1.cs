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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Milestone_Project
{
    public partial class BookStore : Form
    {
        //Declares the inventory class and inventoryItems Array to be within the scope of the entire bookstore class
        Inventory inventory = new Inventory();
        public InventoryManager inventoryManager = new InventoryManager();
        public ArrayList inventoryItems;

        public BookStore()
        {
            InitializeComponent();
            //populates inventoryItems with the starting inventory items and displays them
            inventoryItems = inventory.populateInventory();
            inventoryManager.initializeArray(inventoryItems);
            showInventory(inventoryItems);
        }

        //Method is used for displaying inventory results
        public void showInventory(ArrayList books)
        {
            //clears existing items
            resultsLst.Items.Clear();
            //will go through each item in the passed in struct array list and the appropriate items to their correct rows/columns
            foreach (Inventory.inventoryStruct item in books)
            {
                ListViewItem lvItem = new ListViewItem(item.title);
                lvItem.SubItems.Add(string.Join(", ", item.genre));
                lvItem.SubItems.Add(item.quantity.ToString());
                lvItem.SubItems.Add(item.price.ToString());
                lvItem.SubItems.Add(item.pageCount.ToString());
                lvItem.SubItems.Add(item.productID.ToString());
                resultsLst.Items.Add(lvItem);
            }
        }
        

        //If searchBy is Title it will show the text box if it is genre it will show a combo box
        private void searchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(searchBy.SelectedIndex != -1)
            {
                if(searchBy.SelectedIndex == 0)
                {
                    searchCombo.Visible = true;
                    searchTxt.Visible = false;
                }
                 else if (searchBy.SelectedIndex == 1)
                {
                    searchCombo.Visible = false;
                    searchTxt.Visible = true;
                }
            }
        }

        //Displays form needed to add an inventory item
        private void addBtn_Click(object sender, EventArgs e)
        {
            UpdateInventory updateInventory = new UpdateInventory(this, "Add Book");
            updateInventory.Show();
        }
        

        //Calls on methods from the inventory class to search contents based off of title or genre
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Conditional checks if Title or genre was selected.
            if (searchBy.SelectedIndex >= 0 && searchBy.SelectedItem.Equals("Title"))
            {
                showInventory(inventory.search(searchBy.Text, inventoryItems, searchTxt.Text, outOfStockChk.Checked));
            }
            else if(searchBy.SelectedIndex >= 0 && searchBy.SelectedItem.Equals("Genre"))
            {
               showInventory(inventory.search(searchBy.Text, inventoryItems, searchCombo.Text, outOfStockChk.Checked));
            }
            else
            {
                showInventory(inventory.search(inventoryItems, outOfStockChk.Checked));
            }
        }

        private void resultsLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Enables the ability to click add, remove, restock when a title is selected
            editBtn.Enabled = true;
            removeBtn.Enabled = true;
            restockBtn.Enabled = true;
        }

        //Displays form to update inventory.
        private void editBtn_Click(object sender, EventArgs e)
        {
            string[] editArr = {resultsLst.SelectedItems[0].SubItems[0].Text,
                resultsLst.SelectedItems[0].SubItems[2].Text, resultsLst.SelectedItems[0].SubItems[3].Text, resultsLst.SelectedItems[0].SubItems[3].Text};
            UpdateInventory updateInventory = new UpdateInventory(this, "Edit Book", editArr);

            updateInventory.Show();

            //Disables buttons that rely on an item to be selected.
            editBtn.Enabled = false;
            removeBtn.Enabled = false;
            restockBtn.Enabled = false;
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            //Replaces the existing inventory array with the updated inventory
            inventoryItems = inventoryManager.remove(resultsLst.SelectedIndices[0]);
            //Repopulates the displayed inventory with correct information.
            showInventory(inventoryItems);
        }
        
        //Restocks existing items.
        private void restockBtn_Click(object sender, EventArgs e)
        {
            //Initializes and displays the restock form
            Restock restock = new Restock(this);
            restock.ShowDialog();
            
            //Disables buttons that rely on an item to be selected.
            editBtn.Enabled = false;
            removeBtn.Enabled = false;
            restockBtn.Enabled = false;
        }
    }
}
