using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application
{
    class Member: Person
    {
        public List<Book> booksList;
        string ReturnBookId;
        enum MemberTypes { student, teachingFaculty,nonTeachingFaculty,clerk};
        public void Memeber()
        {
            
        }
        public void Memeber(int id, string name, string address)
        {
           
        }
        public void IssueBook() { }
        public void ReturnBook()
        {
            
                Book book = new Book();
                Console.WriteLine("Enter following details :");

                Console.Write("Enter Book id : ");
                 ReturnBookId = Console.ReadLine();

                Console.Write("Number of Books:");
                int returnCount = int.Parse(Console.ReadLine());

                if (booksList.Exists(book1=> book1.BookId == ReturnBookId))
                {
                    foreach (Book addReturnBook in booksList)
                    {
                        
                            if (addReturnBook.BookId == ReturnBookId)
                            {
                               
                            }
                        }

                       
                    }
                
                else
                {
                    Console.WriteLine("Book id {0} not found", ReturnBookId);
                }

            }
            public void  RenewBook() { }


    }
}
