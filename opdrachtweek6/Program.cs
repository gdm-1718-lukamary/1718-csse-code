using System;
using System.Collections.Generic;

namespace opdrachtweek6
{
    class Program
    {
        static void Main(string[] args)
        {

            Author jk = new Author("J.K. Rowling", "jkrow@hotmail.not", 'f');
            Author notjk = new Author("J.K. Rowlings deranged cousin", "jkrowcous@hotmail.not", 'm');

            List<Author> authors = new List<Author>();
            authors.Add(jk);
            authors.Add(notjk);

            Book hp = new Book("Harry Potter", authors, 11.95, 4);
            
            
            //checks
            Console.WriteLine(hp.getName());
            Console.WriteLine(hp.getPrice());
            hp.setPrice(20);
            Console.WriteLine(hp.getPrice());
            Console.WriteLine(hp.getQtyInStock());
            hp.setQtyInStock(8);
            Console.WriteLine(hp.getQtyInStock());
            Console.WriteLine(hp.getAuthorName(0));
            Console.WriteLine(hp.getAuthorName(1));
        }
    }
}
