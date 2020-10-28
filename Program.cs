
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application

{
class Program
    {
        static List<Book> list;
        static int DisplayMenuForLibrarian()
    {
        int choice;
        Console.WriteLine("1. Add New Book");
        Console.WriteLine("2. List of Books");
        Console.WriteLine("3. Search Book");
        Console.WriteLine("4. Edit Book");
        Console.WriteLine("5. Delete Book");
        Console.WriteLine("Enter your choice");
        int.TryParse(Console.ReadLine(), out choice);
        return choice;
    }
    // List<Book> books;
    static void Main(string[] args)
    {
        int choice;
        Console.WriteLine("1. You are Admin");
        Console.WriteLine("2. You are Member");
        int.TryParse(Console.ReadLine(), out choice);



        switch (choice)
        {
            case 1:
                Librarian person = new Librarian();
                Console.WriteLine("Which operation to perform");
                int adminChoice = DisplayMenuForLibrarian();
                switch (adminChoice)
                {
                    case 1:
                        {
                            person.AddNewBook();
                          
                            person.DisplayBookList();

                            break;
                        }

                    case 2:
                        {
                          
                            person.DisplayBookList();
                            break;
                        }
                        case 3:
                            {

                                Person person1 = new Member();
                                person1.DisplayBooksDetails();
                                break;
                            }
                        case 5:
                            {
                                person.DisplayBookDeleteMassage();
                                break;
                            }
                }
                break;

        }

    }
}
}
