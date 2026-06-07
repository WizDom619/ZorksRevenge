using System;
using System.Collections.Generic;

namespace ZorksRevenge
{
    // Access anything relevant to items is managed here. 
    // Item data is in a separate class. 
    // Items are instantiated in another class and returned, keeps things cleaner.  

    internal class ItemManager
    {
        private List<Item> items; //{ get; }

        public ItemManager()
        {
            items = new ItemData().InstantiateItemData(); 
        }
        public void Add_Item(Item item)
        {
            items.Add(item);
        }
        public void Remove_Item(Item item)
        {
            items.Remove(item);
        }
        public Item Find_Item(string name)
        {
            Item return_item = new Item("Unknown Item", "Unknown Desc");

            foreach (Item item in items)
            {
                if (item.Name == name)
                {
                    return_item = item;
                }
            }
            return return_item;
        }

        public void Change_Item_Name(string old_name, string new_name)
        {

            foreach (Item item in items)
            {
                if (item.Name == old_name)
                {
                    item.Change_Name(new_name);
                }
            }
        }
        public string To_String()
        {
            string result = "";

            foreach (Item item in items)
            {
                result += item.To_String();
            }

            return result; 
        }
    }    
}
