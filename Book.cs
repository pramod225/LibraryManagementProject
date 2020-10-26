using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Application
{
   
    public enum Genre { Drama, Comedy, Programming, Story, Romantic,Riligon};
   public  class Book
    {

        
        public Genre genre { get; set; }
        public bool Status { get; set; }
       public  string BookId { get; set; }
        public string BookName { get; set; }
         public string BookAuthorName { get; set; }
         public string BookPublishedDate { get; set; }
        public float BookPrice { get; set; }

        
        
            
             
        public void GetInitialBook()
        {
           

        }
       
    }
}
