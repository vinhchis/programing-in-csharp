using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ASS_Final
{
    public delegate void CallEvent(string s);
    internal class BookManage : IEnumerable
    {
        private List<Book> books;
        public CallEvent Event;

        public BookManage()
        {
            books = new List<Book>();
            Event += GetMessage;
        }

        private void GetMessage(string s)
        {
            Console.WriteLine("\tMessage: " + s);
        }


        public void createBook()
        {
            Book book = new Book();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Title:");
                    book.Title = Console.ReadLine().Trim();
                    break;

                }
                catch (Exception ex)
                {
                    Event(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Price:");
                    book.Price = Convert.ToDouble(Console.ReadLine().Trim());
                    break;

                }
                catch (Exception ex)
                {
                    Event(ex.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter isSale (true or false):");
                    string sSale = Console.ReadLine().Trim();
                    if (sSale.Equals("true"))
                    {
                        book.IsSale = true;
                    }
                    else if(sSale.Equals("false"))
                    {
                        book.IsSale = false;
                    }else
                    {
                        throw new ArgumentException("Your choice is not right!!!");
                    }

                    break;  

                }
                catch (Exception ex)
                {
                    Event(ex.Message);
                }
            }

            books.Add(book);

        }




        public void FinByIsSale(bool sale)
        {
            Console.WriteLine($"\tList Book with isSale = {sale}");
            foreach(Book book in books)
            {
                if(book.IsSale)
                {
                    Console.WriteLine(book);
                }
            }

        }

        public void FindAll()
        {
            if(books.Count == 0)
            {
                Event("List is empty");
            }
            else
            {
                foreach (Book book in this)
                {
                    book.BookInfo();
                }
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            return books.GetEnumerator();
        }
    }
}
