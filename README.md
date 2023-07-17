Create an application that models a library. The library has different types of items such as books, DVDs, and CDs. Your task is to create interfaces and classes that represent these items, and implement methods that are appropriate for each item.

Part 1: Create Interfaces
First, create the following interfaces:

ILoanable: defines the properties and methods that an item that can be borrowed should have. This should include properties such as LoanPeriod and Borrower, as well as methods such as Borrow and Return.

IPrintable: defines the method Print, which should print out information about the item.



Part 2: Create Classes
Next, create classes that implement the ILoanable and IPrintable interfaces for the following types of items:

Book: has properties such as Author, Title, and ISBN, and should be loanable for 21 days.

DVD: has properties such as Director, Title, and LengthInMinutes, and should be loanable for 7 days.

CD: has properties such as Artist, Title, and NumberOfTracks, and should be loanable for 14 days.

Each class should implement the ILoanable and IPrintable interfaces in a way that is appropriate for that item.



Part 3: Test Your Implementation
This Main() method creates objects of the CD, DVD, and Book classes and sets their properties to some example values. It then calls the Print() method on each object to display information about it. Invoke other methods such as Borrow() and Return() on applicable objects.



Questions for this assignment
Check your source code with Instructor's solution.

You can download the Instructor's solution after you submit your solution.

