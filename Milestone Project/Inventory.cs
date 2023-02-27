﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Project
{
    public class Inventory
    {
        //Initalizes the inventoryStruct which defines the properties for each item in the inventory
        public struct inventoryStruct
        {
            public int quantity;
            public int price;
            public int pageCount;
            public int productID;
            public string[] genere;
            public string title;
        }

        //Will return an ArrayList of inventoryStructs.
        //The ArrayList is generated by reading a txt file.
        public ArrayList populateInventory()
        {
            //Initializes the ArrayList
            var inventory = new ArrayList();

            //Will go through each line in the text file
            foreach (string line in System.IO.File.ReadLines(@"C:\Users\ackle\OneDrive\Desktop\GCU\CST-150 Code\Milestone Project\Milestone Project\Inventory.txt"))
            {
                //Turns each row into an array based off a comma
                String[] rows = line.Split(',');

                //Uses the array to define the struct and then add said struct to the Arraylist
                inventoryStruct book = new inventoryStruct();
                book.title = rows[0];
                book.genere = rows[1].Split('-');
                book.quantity = int.Parse(rows[2]);
                book.price = int.Parse(rows[3]);
                book.pageCount = int.Parse(rows[4]);
                book.productID = int.Parse(rows[5]);

                inventory.Add(book);
            }

            //Returns the struct ArrayList
            return inventory;
        }

        //Search for specific items that match search params
        //Takes in the search type either Title or Genere
        //Takes in the current inventory to search against
        //Takes in the user entered/selected search param
        public ArrayList search(String searchType, ArrayList inventoryItems, String searchParam)
        {
            //Initializes ArrayList for the return results
            ArrayList results = new ArrayList();
            
            //Goes through each item of the existing inventory
            foreach(inventoryStruct item in inventoryItems)
            {
                //Conditional checks if it needs to compare against either the Title or Genere
                //If the user entered/selected param matches text it will add it to the results ArrayList
                if (searchType.Equals("Title") && item.title.ToLower().Contains(searchParam.ToLower()))
                {
                    results.Add(item);
                }
                else if (searchType.Equals("Genere") && Array.Find(item.genere, element => element.Contains(searchParam)) != null)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
