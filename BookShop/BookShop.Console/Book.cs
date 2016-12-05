using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Console
{
    class Book
    {
        private string _title;
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        
        private string _author;
        public string author
	    {
		    get { return _author; }
		    set { _author = value; }
	    }
	
	    private string _isbn;
        public string isbn
	    {
		    get { return _isbn; }
		    set { _isbn = value; }
	    }

        private int _numberOfPages;
        public int numberOfPages
        {
            get { return _numberOfPages; }
            set { 
                    if (value > 0)
                    {
                        _numberOfPages = value;
                    }
                }   
        }

        private double _price;
        public double price
        {
            get { return _price; }
            set { _price = value; }
        }   

        public Book(string Title, string Author)
        {
            title = Title;
            author = Author;
        }
    }
}
