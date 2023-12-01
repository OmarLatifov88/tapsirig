using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tapsirig21
{
    public class Library
    {
        private Book[] books;
        public Library()
        {
            books = new Book[0];
        }
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
                books[books.Length - 1] = book;
        }
        public Book FindAll1(Book book)
        {
            foreach (var item in books)
            {
                if (item == book)
                    return item;
            }
            return null;
        }
        public Book Find1(Predicate<Book> predicate)
        {
            foreach (var item in books)
            {
                if (predicate(item))
                   return item;
            }
            return null;

        }
        //public void Main()
        //{
        //    int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
        //    int length = a.Length;

        //    if (Exists2(a, length, 5))
        //        Console.WriteLine("5 found in array");
        //    else
        //        Console.WriteLine("Could not find 5 in array");
        //    return 0;
        //}

        public bool Exists2(int[] array, int length, int value)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == value) 
                    return true;
            }
            return false;
        }
        //public bool Contains1(Book book)
        //{
        //    for (int i = 0; i < books.Length; i++)
        //    {
        //        if (books[i] == book)
        //            return true;
        //        for(int j = 0; j < book.Length; j++)
        //    }
        //    return false;

        }
    //static void Main(string[] args)
    //{
    //    string path = @"F:data.txt";
    //    if(File.Exists(path))
    //    {
    //        Console.WriteLine("there is a file..");
    //    }
    //    else
    //    {
    //        Console.WriteLine("File Not Found..");
    //    }
    //    Console.ReadLine();
        //public bool Exists1(Book book)
        //{
        //    foreach(var item in books )
        //{
        //    if (item == book)
        //    {

        //        return true;
        //        Console.WriteLine("exists");
        //    }    
        //}
        //    return false;
        //    Console.WriteLine("doesn t exists");
        
        //}
}

