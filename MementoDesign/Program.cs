using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MementoDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book()
            {
                Author="Test Author",
                Isbn="123",
                BookName="Test Book"
            };
            newBook.ShowBook();
            BookMemento bookMementotemp=newBook.CreateMemento();
            Thread.Sleep(5000);
            newBook.BookName = "Changed Test Book";
            newBook.Isbn = "333";
            newBook.ShowBook();
            newBook.Restore(bookMementotemp);
            newBook.ShowBook();


            Console.ReadLine();
        }
    }

    class Book
    {
        private string _isbn;
        private string _bookName;
        private string _author;
        private DateTime _lastEdited;
        public string Isbn { 
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
                _lastEdited = DateTime.UtcNow;
            }
        }
        public string BookName { 
            get 
            {
                return _bookName;
            } 
            set 
            { 
                _bookName = value;
                _lastEdited = DateTime.UtcNow;
            } 
        }
        public string Author {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                _lastEdited = DateTime.UtcNow;
            }
        }

        public void ShowBook()
        {
            Console.WriteLine("{0},{1},{2}, edited at: {3}",_isbn,_bookName,_author,_lastEdited);
        }

        public BookMemento CreateMemento()
        {
            return new BookMemento
            {
                Isbn = _isbn,
                BookName = _bookName,
                Author = _author,
                LastEdited=_lastEdited
            };
        }

        public void Restore(BookMemento bookMemento)
        {
            Isbn = bookMemento.Isbn;
            BookName = bookMemento.BookName;
            Author=bookMemento.Author;
            _lastEdited = bookMemento.LastEdited;
        }
    }

    class BookMemento
    {
        public string Isbn { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public DateTime LastEdited { get; set; }        
    }
}
