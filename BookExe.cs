using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayushi_NVB
{
    public class Books
    {
        int bookId;
        string title;
        string author;
        int pages;
        double originalPrice;
        int volume;
        public int Page { get { return pages; } }

        public Books(int bookId, string title, string author, int pages, double originalPrice, int volume)
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.originalPrice = originalPrice;
            this.volume = volume;
        }
        public void BookDetails()
        {
            Console.WriteLine("Book Id : " + bookId);
            Console.WriteLine("Book name : " + title);
            Console.WriteLine("Book author : " + author);
            Console.WriteLine("No. of pages : " + pages);
            Console.WriteLine("Original price : " + originalPrice);
            Console.WriteLine("Book volume : " + volume);
        }
        public void calDisc()
        {
            if (pages > 500)
            {
                dis
            }
        }
    }
    internal class BookExe
    {
        public static void Main(string[] args)
        {
            Books b1 = new Books(1,"abc","xyz",550,500,2);
            //b1.BookDetails();

            Books b2 = new Books(2, "ab", "xyz", 350, 450, 1);
            //b2.BookDetails();

            //Books b3 = new Books(3, "abc", "xy", 250, 170, 2);
            //b3.BookDetails();

            if (b1.Page > 500)
            {
                b1.BookDetails();
            }
            if (b1.Page > 300)
            {
                b1.BookDetails();
            }
            
        }
    }
}
