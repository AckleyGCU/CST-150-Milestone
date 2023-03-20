using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Milestone_Project.Inventory;

namespace Milestone_Project
{
    public class InventoryManager
    {
        //Initializes the array that will act as the master inventory
        //This Inventory array will store all new changes and edits made to inventory
        ArrayList inventoryItems = new ArrayList();

        //Takes the initial array list that is made from the txt file and converts it to an Array
        public void initializeArray(ArrayList inventory) { 
            inventoryItems.Clear();
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

        public ArrayList updateProductId(ArrayList inventory)
        {
            //Initializes productID, InventoryStruct, and tempList.
            inventoryStruct book = new inventoryStruct();
            int productId = 0;
            ArrayList tempList = new ArrayList();

            //Populates ArrayList items with correct Product ID.
            foreach (Inventory.inventoryStruct item in inventory)
            {
                book.title = item.title;
                book.genre = item.genre;
                book.quantity = item.quantity;
                book.price = item.price;
                book.pageCount = item.pageCount;
                book.productID = productId;
                tempList.Add(book);
                productId++;
            }
            //Returns updated ArrayList
            return tempList;
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
