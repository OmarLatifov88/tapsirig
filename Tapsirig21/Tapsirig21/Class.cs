using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tapsirig21
{
    public class Class
    {
        public Book[] books1;
        public Class()
        {
            books1 = new Book[0];
        }
        public static void Contains1(string[] words1)
        {
            string s1 = "Hello";
            string s2 = "He";
            string s3 = "Hi";
            Console.WriteLine(s1.Contains(s2));
            Console.WriteLine(s1.Contains(s3));
        }
        public static void Main()
        {
            string name = "Kamil";
            string substring = "ka";
            char cheracter = '1';

            bool result;

            result = name.Contains(substring);
            Console.WriteLine(result);

            result = name.Contains(cheracter);
            Console.WriteLine(result);
        }
   
    }
}
