using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public class Catalogue<T> where T : Item //GOOD FOR DEPENDENCY INVERSION
    {
        List<T> items = new List<T>();

        public List<T> GetAllItems()
        {
            return items;
        }

        public void AddItem(T itemToAdd)
        {
            items.Add(itemToAdd);
        }
    }
}
