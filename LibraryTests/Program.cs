// See https://aka.ms/new-console-template for more information
using AutoMoq;
using LibraryAppNi.Data.Model;
using LibraryAppNi.Data.Repository;
using LibraryAppNi.Data.Repository.IRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var mock = new Mock<IBookRepository>();
        _ = mock.Setup(p => p.Delete(-99)).Returns(0);
    }

    [TestMethod]
    public void Create_StateUnderTest_ExpectedBehavior()
    {
        // Arrange
        var mocker = new AutoMoqer();
        var bookRepository = mocker.Create<BookRepository>();
        BookDto bookDto = null;

        // Act
        _ = bookRepository.Create(
            bookDto);

        // Assert
        Assert.Fail();
    }

    [TestMethod]
    public void Create_StateUnderTest_ExpectedBehavior2()
    {
        // Arrange
        var mocker = new AutoMoqer();
        var bookRepository = mocker.Create<BookRepository>();
        var bookDto = new BookDto();

        // Act
        _ = bookRepository.Create(
            bookDto);

        // Assert
        Assert.Fail();
    }
    #region BookModelTests

    [TestMethod]
    public void newBook_setGetTitle()
    {
        // Arrange
        var book = new BookDto();
        var expectedTitle = "yes";

        // Act
        book.Author = expectedTitle;

        // Assert
        _ = Assert.Equals(book.Author, expectedTitle);
    }

    [TestMethod]
    public void newBook_isNotBorrowed()
    {
        // Arrange
        var book = new BookDto();

        // Act
        var expectedvalue = false;

        // Assert
        _ = Assert.Equals(book.IsBorrowed, expectedvalue);
    }

    #endregion

    #region BorrowTests
    [TestMethod]
    public void newBorrow_defaultBorrowDate()
    {
        // Arrange
        var borrow = new BorrowDto();

        // Act
        var expectedvalue = DateTime.Today;

        // Assert
        _ = Assert.Equals(borrow.BorrowDate, expectedvalue);
    }
    [TestMethod]
    public void newBorrow_defaultBorrowDeadline()
    {
        // Arrange
        var borrow = new BorrowDto();

        // Act
        var expectedvalue = DateTime.Today;

        // Assert
        _ = Assert.Equals(borrow.BorrowDeadline, expectedvalue);
    }

    [TestMethod]
    public void newBorrow_BorrowDeadlineDeadline()
    {

        // Arrange
        var mock = new Mock<IBorrowRepository>();
        var start = DateTime.Today.AddDays(-5);
        var end = DateTime.Today;

        var expectedvalue = false;

        _ = mock.Setup(p => p.ValidateDeadLine(start, end).Equals(false));

        end = DateTime.Today.AddDays(-8);

        _ = mock.Setup(p => p.ValidateDeadLine(start, end).Equals(true));
    }

    #endregion

    #region MemberModelTests

    [TestMethod]
    public void newMember_defaultBirthdate()
    {
        // Arrange
        var member = new MemberDto();

        // Act
        var expectedvalue = DateTime.Today;

        // Assert
        _ = Assert.Equals(member.BirthDate, expectedvalue);
    }

    [TestMethod]
    public void newMemberValidateNames()
    {

        // Arrange
        var mock = new Mock<IMemberRepository>();
        var name = "";
        var name2 = ",";
        var name3 = " ";
        var name4 = " gd";
        var name5 = "ui43";
        var name6 = "-45c.";


        _ = mock.Setup(p => p.ValidateName(name).Equals(false));
        _ = mock.Setup(p => p.ValidateName(name2).Equals(false));
        _ = mock.Setup(p => p.ValidateName(name3).Equals(false));
        _ = mock.Setup(p => p.ValidateName(name4).Equals(true));
        _ = mock.Setup(p => p.ValidateName(name5).Equals(true));
        _ = mock.Setup(p => p.ValidateName(name6).Equals(false));
    }

    #endregion
}
