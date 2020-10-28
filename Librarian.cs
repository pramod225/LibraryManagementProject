using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace LMS.Application
{

    public class Librarian 
    {
        
         public List<Book> booksList;
        static  Book book = new Book();
        string Massage;
        void InitializeBooks()
        {
            booksList = new List<Book>()
            {
                new Book() { BookId = "B001", BookName = "Geeta", BookAuthorName = "Balmiki", BookPublishedDate = "11/01/2020", genre = Genre.Riligon, BookPrice = 200 },
                new Book() { BookId = "B002", BookName = "Ramayan", BookAuthorName = "Balmiki", BookPublishedDate = "11/01/1990", genre = Genre.Riligon, BookPrice = 400 },
                new Book() { BookId = "B003", BookName = "java", BookAuthorName = "Oak", BookPublishedDate = "11/01/1987", genre = Genre.Programming, BookPrice = 600 },
                new Book() { BookId = "B004", BookName = "KabilSharma", BookAuthorName = "Kapil", BookPublishedDate = "11/01/2018", genre = Genre.Comedy, BookPrice = 1000 },
                new Book() { BookId = "B005", BookName = "SIdeEffect", BookAuthorName = "Tom", BookPublishedDate = "11/01/1890", genre = Genre.Comedy, BookPrice = 2100 }

            };


        }

        public void AddNewBook()
        {
            InitializeBooks();
            
            try
            {
                Console.WriteLine("Enter Book Id");
                book.BookId = Console.ReadLine();
                if (book.BookId == null)
                {
                    throw new CustomException("Book id is must");
                }
                Console.WriteLine("Enter Book Name");
                book.BookName = Console.ReadLine();
                if (book.BookName == null)
                {
                    throw new CustomException("Book name is must");
                }
                Console.WriteLine("Enter Book Author Name");
                book.BookAuthorName = Console.ReadLine();
                if (book.BookAuthorName == null)
                {
                    throw new CustomException("Book author name is must");
                }
                Console.WriteLine("Enter Book Pulished date");
                book.BookPublishedDate = Console.ReadLine();
                if (book.BookPublishedDate == null)
                {
                    throw new CustomException("Book published date should have beeen");
                }
                Console.WriteLine("Enter Book price");
                book.BookPrice = float.Parse(Console.ReadLine());
                if (book.BookPrice == 0)
                {
                    throw new CustomException("Book Price should have beeen");
                }
                booksList.Add(book);
            }
            catch (CustomException obj)
            {
                Console.WriteLine(obj.Message);
            }
            catch (Exception obj)
            {
                Console.WriteLine(obj.Message);

            }
        }
        public List<Book> GetBooks()
        {
            return booksList;
        }
        public void DisplayBookList()
        {
            Console.WriteLine("Book ID \t Book Name \t Author Name \t Publish Date \t Genre \t Price");
            if (booksList.Count == 0)
            {
                Console.WriteLine("No books available");
            }
            else
            {
                foreach (Book temp in booksList)
                {
                    Console.WriteLine(temp.BookId + "\t" + temp.BookName + "\t" + temp.BookAuthorName + "\t"
                       + temp.BookPublishedDate + "\t" + temp.genre + "\t" + temp.BookPrice);
                }
            }
           

        }
         void DeleteBook()
        {
            try
            {
                Console.WriteLine("Enter Book id to Delete");
                book.BookId = Console.ReadLine();
                Console.WriteLine("Enter Book Name to Delete");
                book.BookName = Console.ReadLine();
                if (booksList.Exists(book1 => book1.BookId == book.BookId))
                {
                    booksList.Remove(book);
                }
                if (booksList.Exists(book2 => book2.BookName == book.BookName))
                {
                    booksList.Remove(book);
                }
                else
                {
                    Massage = "Invalid Book Id and Book Name Please try again";
                }
                booksList.Add(book);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            }

       public void DisplayBookDeleteMassage()
        {
            DeleteBook();
            Console.WriteLine("Book deleted Successfully"+book.BookId);
            Console.WriteLine("Book deleted Successfully" + book.BookName);
            Console.WriteLine(Massage);
        } 



    }
}
