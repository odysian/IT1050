using System;

#nullable disable

public class Book
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public Author AuthorInfo { get; set; }
    public DateTime PublishedOn { get; set; }
    public string PublishedBy { get; set; }
    
    public Book(string isbn, string title, Author authorInfo) 
    {
        ISBN = isbn;
        Title = title;
        AuthorInfo = authorInfo;
        PublishedOn = DateTime.Today;
        PublishedBy = "Unknown";
    }
    
    public Book(string isbn, string title, Author authorInfo, DateTime publishedOn, string publishedBy)
    {
        ISBN = isbn;
        Title = title;
        AuthorInfo = authorInfo;
        PublishedOn = publishedOn;
        PublishedBy = publishedBy;
    }
    
    public void Display()
    {
        
        Console.WriteLine($"'{Title}' was written by {AuthorInfo.FirstName} {AuthorInfo.LastName} " +
                          $"and published on {PublishedOn:MM/dd/yyyy}");
        // Console.WriteLine("ISBN: " + ISBN);
        // Console.WriteLine("Title: " + Title);
        // Console.WriteLine("Author: " + AuthorInfo.FirstName + " " + AuthorInfo.LastName);
        // Console.WriteLine($"Published On: {PublishedOn:MM/dd/yyyy}");
        // Console.WriteLine("Published By: " + PublishedBy);
    }
}