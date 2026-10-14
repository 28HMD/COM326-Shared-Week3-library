
using System;
using System.Collections.Generic;
using Library;

class Program
{
    static void Main(string[] args)
    {
        // Create lists to store books and members
        List<Book> books = new List<Book>();
        List<Member> members = new List<Member>();

        // Add first book
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "1234567";
        books.Add(book);

        // Add second book
        Book book1 = new Book();
        book1.Title = "Ultimate C#";
        book1.Author = "Microsoft";
        book1.ISBN = "2233445";
        books.Add(book1);

        // Add members to the list
        members.Add(new Member(
            1, "John Smith", "1 High Street", 0790090090));

        members.Add(new Member(
            2, "Mary Jones", "102 Garden Road", 0790345666));

        // Display all books
        Console.WriteLine("Currently available books");
        Console.WriteLine();

        foreach (Book b in books)
        {
            b.DisplayInfo();
        }

        // Display all members
        Console.WriteLine("Current library members");
        Console.WriteLine();

        foreach (Member m in members)
        {
            m.DisplayInfo();
        }

        // Create a dictionary to track book inventory by ISBN
        Dictionary<string, int> bookInventory = new Dictionary<string, int>();

        // Add books to the inventory (ISBN, Quantity)
        bookInventory.Add("1234567", 5);
        bookInventory.Add("2233445", 2);

        // Display inventory for a specific book
        Console.WriteLine($"Copies of 'C# for beginners' in stock: {bookInventory["1234567"]}");


        Console.WriteLine("Checking inventory for a missing book...");

        try
        {
            // This ISBN does not exist
            Console.WriteLine(bookInventory["9999999"]);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: That ISBN was not found in the inventory system.");
        }
        finally
        {
            Console.WriteLine("Inventory check complete.");
        }


    }
}
