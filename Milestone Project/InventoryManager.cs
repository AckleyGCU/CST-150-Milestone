using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    internal class InventoryManager
    {
        //Initializes the array that will act as the master inventory
        //This Inventory array will store all new changes and edits made to inventory
        ArrayList inventoryItems = new ArrayList();

        //Takes the initial array list that is made from the txt file and converts it to an Array
        public void initializeArray(Array inventory) { 
            inventoryItems.AddRange(inventory);
        }

        //Adds a new item and returns the new inventory array to be processed and displayed on the resultsLst
        public ArrayList add(Inventory.inventoryStruct newItem)
        {
            inventoryItems.Add(newItem);
            return inventoryItems;
        }

        //Removes an existing item and returns the new inventory array to be processed and displayed on the resultsLst
        public ArrayList remove(int productId)
        {
            //Removes item based off of the passed in productId
            inventoryItems.RemoveAt(productId);
            return inventoryItems;
        }

        //Edits an existing item and returns the new inventory array to be processed and displayed on the resultsLst
        public ArrayList edit(Inventory.inventoryStruct editedItem)
        {
            inventoryItems.RemoveAt(editedItem.productID);
            inventoryItems.Insert(editedItem.productID, editedItem);
            return inventoryItems;
        }
    }
}
