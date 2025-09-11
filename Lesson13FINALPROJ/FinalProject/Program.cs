using System;

class Program
{
    static void Main() {
        
        // Create authors and display info
        Console.WriteLine();
        Author a1 = new Author("J.R.R.", "Tolkien", "jrr.tolkien@gmail.com");
        a1.DisplayInfo();
        
        Author a2 = new Author("Mark", "Twain", "mark.twain@gmail.com");
        a2.DisplayInfo();

        // Create books
        Book b1 = new Book("978-0547928227", "The Hobbit", a1);
        
        Book b2 = new Book("978-1503215672", "The Adventures of Tom Sawyer", a2);
        
        Book b3 = new Book("978-0618135042", "The Silmarillion", a1);
        
        Book b4 = new Book("978-1580495837", "Adventures of Huckleberry Finn", a2,
                          Convert.ToDateTime("02/18/1885").Date, "Charles L. Webster and Company");
        
        Book b5 = new Book("978-0547928210", "The Fellowship of the Ring", a1,
                          Convert.ToDateTime("07/29/1954").Date, "George Allen & Unwin");
        
        Book b6 = new Book("978-0451531209", "Life on the Mississippi", a2,
                          Convert.ToDateTime("05/17/1883").Date, "James R. Osgood and Company");

        // Add books to authors
        Console.WriteLine();
        a1.AddBook(b1);
        a1.AddBook(b3);
        a1.AddBook(b5);
        a1.DisplayBooks();
        Console.WriteLine();
        
        a2.AddBook(b2);
        a2.AddBook(b4);
        a2.AddBook(b6);
        a2.DisplayBooks();
        
        // Remove book 1 with ISBN and display
        Console.WriteLine();
        a1.RemoveBook("978-0547928227");
        a1.DisplayBooks();
    }
}