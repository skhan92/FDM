using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class ItemCatalogue
    {
        List<Item> items = new List<Item>();

        public List<Item> GetAllItems()
        {
            return items;
        }

        public void AddItem(Item itemToAdd)
        {
            items.Add(itemToAdd);
        }
    }
}
