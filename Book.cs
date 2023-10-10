using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    class Book
        {
            public string title;
            public string author;
            public int pages;
          
           
                public Book( string aTitle, string aAuthor,int aPages)
            {
                title = aTitle;
                author = aAuthor;   
                pages = aPages;
               
            }

            /*static void Main(string[] args)
            {
                Book book1 = new Book();
                book1.title = "Bengilithi Lizokuna";
                book1.author = "Benjamin Nkosi";
                book1.pages = 400;
               

                Book book2 = new Book();
                book2.title = "Long Wark to Freedom";
                book2.author = "Nelson Mandela";
                book2.pages = 784;
             

                Console.WriteLine(book1.pages);
                Console.WriteLine(book2.title);

                Console.ReadLine();

            }*/
        }
}
