public class Cd : Item
{
    string _artist;
    int _numberOfTracks;
    const int _loanPeriod = 14;

    public Cd(string artist, int numberOfTracks, string title, string borrower = "")
        : base(title, borrower)
    {
        _artist = artist;
        _numberOfTracks = numberOfTracks;
    }

    public string Artist 
    {
        get { return _artist; }
        set { _artist = value; }
    }

    public int NumberOfTracks
    {
        get { return _numberOfTracks; }
        set { _numberOfTracks = value; }
    }

    public override int LoanPeriod
    {
        get { return _loanPeriod; }
    }

    public override void Print()
    {
        Console.WriteLine($"Type: {this.GetType().ToString()} \nTitle:{Title} \nArtist: {Artist} \nNoTracks: {NumberOfTracks}" +
            $"\nInLibrary: {IsAvailable} \nBorrower: {Borrower} \nLoanPeriod: {LoanPeriod}");
    }
}
