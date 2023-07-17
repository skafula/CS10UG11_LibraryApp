internal class Program
{
    private static void Main(string[] args)
    {
        // Not borrowed book
        Item book1 = new Book("Unborrowed Book", "1111", "First book");
        book1.Print();
        
        Console.WriteLine();

        // Borrowed book
        Item book2 = new Book("Borrowed Book", "2222", "Second book", "John Doe");
        book2.Print();
        
        Console.WriteLine();

        // Not borrowed book
        Item cd1 = new Cd("Unborrowed Cd", 5, "First Cd");
        cd1.Print();

        Console.WriteLine();

        // Borrowed book
        Item cd2 = new Cd("Borrowed Cd", 3, "Second Cd", "Martha Doe");
        cd2.Print();

        Console.WriteLine();

        // Not borrowed book
        Item dvd1 = new DVD("Unborrowed Dvd", 65, "First Dvd");
        dvd1.Print();

        Console.WriteLine();

        // Borrowed book
        Item dvd2 = new DVD("Borrowed Dvd", 72, "Second Dvd", "John Doe");
        dvd2.Print();

        Console.WriteLine();

        dvd2.Return();
        dvd2.Print();

        Console.WriteLine();

        dvd2.Borrow("Jancsika");
        dvd2.Print();

        Console.WriteLine();
    }
}