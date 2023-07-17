interface ILoanable
{
    string Borrower { get; set; }

    int LoanPeriod { get; }

    void Borrow(string name);

    void Return();
}