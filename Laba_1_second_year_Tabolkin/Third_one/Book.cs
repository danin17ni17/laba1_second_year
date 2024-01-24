using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_one
{
    public class Book
    {
        string author;
        string title;
        int price;
        int year;
        public Book(string a, string t, int p, int y)
        {
            author = a; title = t; price = p; year = y;
        }
        public override string ToString()
        {
            return (title + " : " + author);
        }
        public void PrintBook()
        {
            Debug.WriteLine("автор:" + author + " название: " +
                                           title + " цена: " + price.ToString() +
                                          " год издания: " + year.ToString());
        }
    }
}