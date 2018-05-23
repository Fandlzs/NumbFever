using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbFever.Classes
{
    public static class ItemHandler
    {
        //static class for handling items
        private static List<Item> items;

        static ItemHandler()
        {
            items = new List<Item>();
        }

        public static List<Item> GetItems()
        {
            return items;
        }

        public static void ClearItemList()
        {
            items.Clear();
        }

        public static void AddItem(Item item)
        {
            items.Add(item);
        }

        public static void RemoveItem(Item item)
        {
            items.Remove(item);
        }

    }
}
