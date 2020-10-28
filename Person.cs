using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application
{
    abstract class Person
    {
        string SearchBooks;
        public List<Book> booksList;
        static Book book = new Book();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string phonoNumber { get; set; }
         void SearchBookAvailability()
        {
            try
            {

                Console.WriteLine("Enter Book Id and Book Name");
                Console.WriteLine("Enter Book Id ");
                book.BookId = Console.ReadLine();
                Console.WriteLine("Enter Book Name ");
                book.BookName = Console.ReadLine();
                if (booksList.Exists(book1 => book1.BookId == book.BookId))
                {
                    foreach (Book searchedBookId in booksList)
                    {
                        SearchBooks = "Book Id:{0}" + searchedBookId.BookId + "Book Name:{1}" + searchedBookId.BookName + "Book Price" + searchedBookId.BookPrice +
                            "Book Author Name" + searchedBookId.BookAuthorName + "Book Price" + searchedBookId.BookPrice;
                    }
                }
                if (booksList.Exists(book1 => book1.BookName == book.BookName))
                {
                    foreach (Book searchedBookId in booksList)
                    {
                        SearchBooks = "Book Id:{0}" + searchedBookId.BookId + "Book Name:{1}" + searchedBookId.BookName + "Book Price" + searchedBookId.BookPrice +
                            "Book Author Name" + searchedBookId.BookAuthorName + "Book Price" + searchedBookId.BookPrice;
                    }
                }
                else
                {
                    SearchBooks = "Not Found Try Again";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DisplayBooksDetails() 
        {
            SearchBookAvailability();
            Console.WriteLine(SearchBooks);
        }
        public void CheckBooksList()
        {

        }
    }
}
