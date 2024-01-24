using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_One
{
    public class Books
    {
        private int maxBooks;
        private string[] bookList;
        private int currentIndex;

        public Books(int max)
        {
            maxBooks = max;
            bookList = new string[maxBooks];
            currentIndex = 0;
        }

        public void AddBook(string bookTitle)
        {
            if (currentIndex < maxBooks)
            {
                bookList[currentIndex] = bookTitle;
                currentIndex++;
            }
        }

        public string[] GetBooks()
        {
            return bookList;
        }
    }
}