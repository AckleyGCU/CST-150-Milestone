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
        InventoryManager inventoryManager = new InventoryManager();
        object[] inventoryItems;
        public BookStore()
        {
            InitializeComponent();
            //populates inventoryItems with the starting inventory items and displays them
            inventoryItems = inventory.populateInventory().ToArray();
            inventoryManager.initializeArray(inventoryItems);
            showInventory(inventoryItems);
            
        }

        //Method is used for displaying inventory results
        private void showInventory(Array books)
        {
            //clears existing items
            resultsLst.Items.Clear();
            //will go through each item in the passed in struct array list and the appropriate items to their correct rows/columns
            foreach (Inventory.inventoryStruct item in books)
            {
                ListViewItem lvItem = new ListViewItem(item.title);
                lvItem.SubItems.Add(string.Join(", ", item.genere));
                lvItem.SubItems.Add(item.quantity.ToString());
                lvItem.SubItems.Add(item.price.ToString());
                lvItem.SubItems.Add(item.pageCount.ToString());
                lvItem.SubItems.Add(item.productID.ToString());
                resultsLst.Items.Add(lvItem);
            }
        }
        
        //Takes in a bool to either show or hide the field neccessary to add or edit an inventory item
        private void showAddEdit(bool visible)
        {
            titleLbl.Visible = visible;
            genereLbl.Visible = visible;
            priceLbl.Visible = visible;
            quantityLbl.Visible = visible;
            pageCountlbl.Visible = visible;
            addTitle.Visible = visible;
            genereBox.Visible = visible;
            addPrice.Visible = visible;
            addQuantity.Visible = visible;
            addPageCount.Visible = visible;
            cancelBtn.Visible = visible;
            confirmBtn.Visible = visible;
            resultsLst.Visible = !visible;
        }

        //If searchBy is Title it will show the text box if it is Genere it will show a combo box
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

        //Display the fields needed to add an inventory item
        private void addBtn_Click(object sender, EventArgs e)
        {
            showAddEdit(true);
            confirmBtn.Text = "Add Book";
            resultsLst.Visible = false;
        }
        
        //Hides the fields needed to add an inventory item
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            showAddEdit(false);
            resultsLst.Visible = true;
            addBtn.Enabled = true;
            
            //Resets input fields
            addTitle.Text = "";
            addQuantity.Text = "";
            addPrice.Text = "";
            addPageCount.Text = "";
        }

        //Calls on methods from the inventory class to search contents based off of title or genere
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Conditional checks if Title or Genere was selected.
            if (searchBy.SelectedIndex >= 0 && searchBy.SelectedItem.Equals("Title"))
            {
                showInventory(inventory.search(searchBy.Text, inventoryItems, searchTxt.Text, outOfStockChk.Checked));
            }
            else if(searchBy.SelectedIndex >= 0 && searchBy.SelectedItem.Equals("Genere"))
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
            //Enables the ability to click add or remove when a title is selected
            editBtn.Enabled = true;
            removeBtn.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            //Enables and disables buttons to direct user interaction.
            editBtn.Enabled = false;
            removeBtn.Enabled = false;
            addBtn.Enabled = false;
            resultsLst.Visible = false;
            confirmBtn.Enabled = true;
            confirmBtn.Text = "Edit Book";

            //Fills in input fields with the selected titles information
            addTitle.Text = resultsLst.SelectedItems[0].SubItems[0].Text;
            addQuantity.Text = resultsLst.SelectedItems[0].SubItems[2].Text;
            addPrice.Text = resultsLst.SelectedItems[0].SubItems[3].Text;
            addPageCount.Text = resultsLst.SelectedItems[0].SubItems[4].Text;

            showAddEdit(true);
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            //Replaces the existing inventory array with the updated inventory
            inventoryItems = inventoryManager.remove(resultsLst.SelectedIndices[0]).ToArray();
            //Repopulates the displayed inventory with correct information.
            showInventory(inventoryItems);
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Inventory.inventoryStruct inventoryUpdate = new Inventory.inventoryStruct();
            inventoryUpdate.title = addTitle.Text;
            if (int.TryParse(addPrice.Text, out int price)) { inventoryUpdate.price = price; }
            if (int.TryParse(addQuantity.Text, out int quantity)) { inventoryUpdate.quantity = quantity; }
            if (int.TryParse(addPageCount.Text, out int pages)) { inventoryUpdate.pageCount = pages; }

            string[] genere = new string[genereBox.SelectedItems.Count];
            genereBox.SelectedItems.CopyTo(genere, 0);
            inventoryUpdate.genere = genere;

            if (confirmBtn.Text.Equals("Add Book"))
            {
               inventoryUpdate.productID = inventoryItems.Length;
               //Replaces the existing inventory array with the updated inventory
               inventoryItems = inventoryManager.add(inventoryUpdate).ToArray();
            }
            else if(confirmBtn.Text.Equals("Edit Book")) 
            {
                inventoryUpdate.productID = int.Parse(resultsLst.SelectedItems[0].SubItems[5].Text);

                Console.WriteLine("Test");
                //Replaces the existing inventory array with the updated inventory
                inventoryItems = inventoryManager.edit(inventoryUpdate).ToArray();
            }
            //Repopulates the displayed inventory with correct information.
            showInventory(inventoryItems);

            addBtn.Enabled = true;

            //Resets input fields
            addTitle.Text = "";
            addQuantity.Text = "";
            addPrice.Text = "";
            addPageCount.Text = "";

            showAddEdit(false);
        }

        private void addEditChanged(object sender, EventArgs e)
        {
            if(addTitle.Text != "" && addQuantity.Text != "" && addPrice.Text != "" && addPageCount.Text != "" && genereBox.SelectedIndices.Count > 0)
            {
                confirmBtn.Enabled = true;
            }
            else { 
                confirmBtn.Enabled = false; 
            }
        }
    }
}
