using System.Runtime.CompilerServices;

public class DVD : Item
{
    string _director;
    int _lengthInMinutes;
    const int _loanPeriod = 7;

    public DVD(string director, int lengthInMinutes, string title, string borrower = "")
        : base(title, borrower)
    {
        _director = director;
        _lengthInMinutes = lengthInMinutes;
    }

    public string Director
    {
        get { return _director; }
        set { _director = value; }
    }

    public int LengthInMinutes
    {
        get { return _lengthInMinutes; }
        set { _lengthInMinutes = value; }
    }

    public override int LoanPeriod
    {
        get { return _loanPeriod; }
    }

    public override void Print()
    {
        Console.WriteLine($"Type: {this.GetType().ToString()} \nTitle:{Title} \nDirector: {Director} \nLength: {LengthInMinutes}" +
            $"\nInLibrary: {IsAvailable} \nBorrower: {Borrower} \nLoanPeriod: {LoanPeriod}");
    }
}