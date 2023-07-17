public class Book : Item
{
    string _author;
    string _isbn;
    const int _loanPeriod = 21;

    public Book(string author, string isbn, string title, string borrower = "") 
        : base(title, borrower)
    {
        _author = author;
        _isbn = isbn;
    }

    public string Author
    {
        get { return _author; }
        set { _author = value; }
    }

    public string ISBN
    {
        get { return _isbn; }
        set
        {
            _isbn = value;
        }
    }

    public override int LoanPeriod 
    {
        get { return _loanPeriod; }
    }

    public override void Print()
    {
        Console.WriteLine($"Type: {this.GetType().ToString()} \nTitle:{Title} \nAuthor: {Author} \nISBN: {ISBN}" +
            $"\nInLibrary: {IsAvailable} \nBorrower: {Borrower} \nLoanPeriod: {LoanPeriod}");
    }
}

