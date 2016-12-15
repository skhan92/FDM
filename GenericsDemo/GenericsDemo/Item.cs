using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    public abstract class Item
    {
        public int id { get; set; }
        public string title { get; set; }
    }
    //BEST PRACTICE TO MAKE A NEW CLASS FOR EACH ONE MANNN
    public class Book : Item
    {
        public string author { get; set; }
    }

    public class Dvd : Item
    {
        public DateTime releaseDate { get; set; }
    }

    public class Magazine : Item
    {
        public int numberOfPages { get; set; }
    }

    public class AudioBook : Item
    {
        public string narrator { get; set; }
    }

    public class Games : Item
    {
        public string title { get; set; }
    }
}
