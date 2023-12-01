using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tapsirig21
{
    public class List1<T> : IEnumerable<T>
    {
        public  T Number;
        private T[] numbers;


        public List1(T number)
        {
            Number = number;
            numbers = new T[0];
        }
        public void Add1(T number1)
        {
            //foreach (var number in numbers)
            
                //if (predicate(number))
                
                    Array.Resize(ref numbers, numbers.Length + 1);
                    numbers[numbers.Length - 1] = number1;
        }

        public void Remove1(T number1)
       {
           //foreach (var number in numbers)

           //if (predicate(number))

           Array.Resize(ref numbers, numbers.Length - 1);
           numbers[numbers.Length + 1] = number1;
    
       }
        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in numbers)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in numbers)
            {
                yield return item;
            }
        }

            //public Book Find1(Predicate<Book> predicate)
            //    {
            //        foreach (var book in books)
            //        {
            //    if (predicate(book))
            //        return book;
            //        }
            //return null;
                }





}


