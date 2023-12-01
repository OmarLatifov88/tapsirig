using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Tapsirig21
{
    public class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        //private Book[] books;
        //public Book()
        //{
        //    //books = new Book[0];
        //}
        //public Book Find1(Predicate<Book> predicate)
        //{
        //    foreach (var item in books)
        //    {
        //        if (predicate(item))
        //            return item;
        //    }
        //    return null;

        //}
        
    }
}