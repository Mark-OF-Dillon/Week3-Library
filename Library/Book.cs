using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Book
    {
        //Private Fields//
        private string title;
        private string author;
        private int isbn;

        //Public Properties//
        public string Title
        {
            get { return title; }
            set 
            {
                //Check if any incoming char is a digit
                if (!value.Any(char.IsDigit))
                {
                    title = value;
                }
                else
                {
                    Console.WriteLine("Cannot enter number for title");
                }
            }

        }
        public string Author
        {
            get { return author; }
            set { author = value;
            
            }
        }
        public int ISBN
        {
            get { return isbn; }
            set { isbn = value;
            
            }
        }

        //Paramaterised Constructor//
        public Book(string bookTitle,string bookAuthor,int bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        //Methods//
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Ttile: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
        }
    }
}
