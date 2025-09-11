using System;
using System.Collections.Generic;
#nullable disable

public class Author : Person
{
    private List<Book> Books = new List<Book>();
    
    public Author() : base() {}
    
    public Author(string firstName, string lastName, string email)
        :base(firstName, lastName, email) {}
    
    public void DisplayInfo()
    {
        Console.WriteLine("First Name: " + FirstName);
        Console.WriteLine("Last Name: " + LastName);
        Console.WriteLine("Email: " + Email);
    }
    
    public void DisplayBooks()
    {
         // decided to stop using + to concat strings, was getting tedious
        Console.WriteLine();
        Console.WriteLine($"Displaying {FirstName} {LastName}'s library");
        foreach (Book book in Books)
        {
            book.Display();
        }
    }
    
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"{book.Title} added to {FirstName} {LastName}'s library");
    }
    
    public void RemoveBook(string isbn)
    {
        Book foundBook = Books.Find(e => e.ISBN == isbn);
        
        if (foundBook != null)
        {
            Books.Remove(foundBook);
            Console.WriteLine(isbn + " removed from library");
        }
    }
}