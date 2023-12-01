using Tapsirig21;
int number4 = 4;
List1<int> numbers = new List1<int>(4);
numbers.Add1(8);
numbers.Add1(9);
//numbers.Remove1(9);
foreach(var item in numbers)
{
    Console.WriteLine(item);
}
LinkedList<int> list = new LinkedList<int>();
Book book1 = new Book();
book1.Name = "Zakir";
book1.AuthorName = "Kamil";
book1.PageCount = 200;
Book book2 = new Book();
book2.Name = "Kemal";
book2.AuthorName = "Zaki";
book2.PageCount = 250;
Library library = new Library();
library.AddBook(book1);
library.AddBook(book2);
Console.WriteLine(library.Find1(book => book.PageCount > 200).Name);
Console.WriteLine(library.FindAll1(book1));
//Console.WriteLine(library.Exists1(book1));

//list.AddLast(4);
//list.AddLast(5);
//foreach(var item in list)
//{
//    Console.WriteLine(item);
//}
//Class class = new Class()
    




    

    


