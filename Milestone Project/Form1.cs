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
        //Declares the inventory class and inventoryItems ArrayList to be within the scope of the entire bookstore class
        Inventory inventory = new Inventory();
        ArrayList inventoryItems = new ArrayList();
        public BookStore()
        {
            InitializeComponent();
            //populates inventoryItems with the starting inventory items and displays them
            inventoryItems = inventory.populateInventory();
            showInventory(inventoryItems);
            
        }

        //Method is used for displaying inventory results
        private void showInventory(ArrayList books)
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
            releaseDateLbl.Visible = visible;
            addTitle.Visible = visible;
            addGenere.Visible = visible;
            addPrice.Visible = visible;
            addQuantity.Visible = visible;
            addPageCount.Visible = visible;
            addReleaseDate.Visible = visible;
            cancelBtn.Visible = visible;
            addItemBtn.Visible = visible;
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
                 else if (searchBy.SelectedIndex == 5)
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
            addItemBtn.Text = "Add Book";
            resultsLst.Visible = false;
        }
        
        //Hides the fields needed to add an inventory item
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            showAddEdit(false);
            resultsLst.Visible = true;
        }

        //Calls on methods from the inventory class to search contents based off of title or genere
        private void searchBtn_Click(object sender, EventArgs e)
        {
            //Conditional checks if Title or Genere was selected.
            if (searchBy.SelectedItem.Equals("Title"))
            {
                showInventory(inventory.search(searchBy.Text, inventoryItems, searchTxt.Text));
            }
            else if(searchBy.SelectedItem.Equals("Genere"))
            {
               showInventory(inventory.search(searchBy.Text, inventoryItems, searchCombo.Text));
            }
        }
    }
}
