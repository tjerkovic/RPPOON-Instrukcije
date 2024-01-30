using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukos_RPPOON_Zadaca7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookCollection bookCollection = new BookCollection();

            bookCollection.books.Add(new Book("Šegrt Hlapić"));
            bookCollection.books.Add(new Book("Vlak u snijegu"));
            bookCollection.books.Add(new Book("Družba Pere Kvržice"));

            BookIterator bookIterator = (BookIterator)bookCollection.CreateIterator();

            bookCollection.books.Add(new Book("Pinokio"));

            while(!bookIterator.HasNext())
            {
                Console.WriteLine(bookIterator.GetNext().title);
            }
        }
    }
    public interface IIterator
    {
        Book GetNext();
        bool HasNext();
    }
    public interface IIteratorCollection
    {
        IIterator CreateIterator();
    }
    public class Book
    {
        public string title;
        public Book(string title)
        {
            this.title = title;
        }
    }
    public class BookIterator:IIterator
    {
        BookCollection bookCollection;
        int state;
        public BookIterator(BookCollection bookCollection)
        {
            this.bookCollection = bookCollection;
            state = 0;
        }
        public Book GetNext()
        {
            Book book = bookCollection.GetBook(state);
            state++;
            return book;
        }
        public bool HasNext()
        {
            return state >= bookCollection.Count();
        }
    }
    public class BookCollection:IIteratorCollection
    {
        public List<Book> books;
        public BookCollection()
        {
            books = new List<Book>();
        }
        public IIterator CreateIterator()
        {
            return new BookIterator(this);
        }
        public Book GetBook(int index)
        {
            return books[index];
        }
        public int Count()
        {
            return books.Count;
        }
    }
}
