public abstract class Item : ILoanable, IPrintable
{
    string _borrower;
    bool _isAvailable;
    string _title;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Borrower 
    { 
        get { return _borrower; }
        set
        {
            if (value == "")
            {
                _borrower = "No one borrows it";
            }
            else 
            {
                _borrower = value;
            }
        }
    }
    public abstract int LoanPeriod { get; }
    public bool IsAvailable
    {
        get { return _isAvailable; }
        set { _isAvailable = value; }
    }

    public Item(string title, string borrower)
    {
        Borrower = borrower;
        _title = title;
        if (Borrower == "No one borrows it")
        {
            IsAvailable = true;
        }
        else
        {
            IsAvailable = false;
        }
    }

    public void Borrow(string name)
    {
        Borrower = name;
        IsAvailable = false;
    }

    public abstract void Print();


    public void Return()
    {
        Borrower = "";
        IsAvailable = true;
    }
}