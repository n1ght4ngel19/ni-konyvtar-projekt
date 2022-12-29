using KonyvtarApp.Data.BookData;
using KonyvtarApp.Data.BorrowData;
using KonyvtarApp.Data.MemberData;

namespace KonyvtarApp.Data.DAL
{
    public class LibraryInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<LibraryContext>
    {
        protected override void Seed(LibraryContext libraryContext)
        {
            var members = new List<Member>
            {
                new Member{MemberID=1 ,Name="Carson Alexander", BirthDate=DateTime.Parse("2005-09-01"), Address="3292 Ashford Drive, Arlington"},
                new Member{MemberID=2 ,Name="Meredith Alonso", BirthDate=DateTime.Parse("2002-09-01"), Address="4597 Hillview Drive, San Francisco"},
                new Member{MemberID=3 ,Name="Arturo Anand", BirthDate=DateTime.Parse("2003-09-01"), Address="3997 Oakwood Circle, Fullerton"},
                new Member{MemberID=4 ,Name="Gytis Barzdukas", BirthDate=DateTime.Parse("2002-09-01"), Address="3240 Seth Street, Lohn"},
                new Member{MemberID=5 ,Name="Yan Li", BirthDate=DateTime.Parse("2002-09-01"), Address="4386 Strother Street, Birmingham"},
                new Member{MemberID=6 ,Name="Peggy Justice", BirthDate=DateTime.Parse("2001-09-01"), Address="3532 Twin Oaks Drive, Grand Rapids"},
                new Member{MemberID=7 ,Name="Laura Norman", BirthDate=DateTime.Parse("2003-09-01"), Address="3838 Bassel Street, Metairie"},
                new Member{MemberID=8 ,Name="Nino Olivetto", BirthDate=DateTime.Parse("2005-09-01"), Address="1513 Gateway Road, Portland"}
            };

            members.ForEach(member => { libraryContext.Members.Add(member); });
            libraryContext.SaveChanges();

            var books = new List<Book>
            {
            new Book{BookID=1234, Title="Wife With Honor" ,Author="Keith Schenider", Publisher="The Melodic Writing", PublishYear=2003, IsBorrowed=true},
            new Book{BookID=6543, Title="Enemy Of The River" ,Author="Keelan Jordan", Publisher="The Acrobatic Robots", PublishYear=1998, IsBorrowed=true},
            new Book{BookID=4041, Title="Doctors Of The Great" ,Author="Keath Franklin", Publisher="The Acrobatic Robots", PublishYear=2013, IsBorrowed=false},
            new Book{BookID=9812, Title="Vultures Without Courage" ,Author="Wesley Snider", Publisher="The Acrobatic Robots", PublishYear=2013, IsBorrowed=false},
            new Book{BookID=1273, Title="Descendants Of The Eclipse" ,Author="Jackie McGee", Publisher="The Melodic Writing", PublishYear=2022, IsBorrowed=true},
            new Book{BookID=7634, Title="Hunters And Enemies" ,Author="Cassidy Marshall", Publisher="The Prestigious Rooms LLC", PublishYear=2018, IsBorrowed=true},
            new Book{BookID=9812, Title="Vengeance With Money" ,Author="Keegan Adkins", Publisher="The Prestigious Rooms LLC", PublishYear=1987, IsBorrowed=true},
            new Book{BookID=1050, Title="Armies And Friends" ,Author="Indigo Roffe", Publisher="The Prestigious Rooms LLC", PublishYear=1991, IsBorrowed=false},
            new Book{BookID=4022, Title="Extinction Of The South" ,Author="Michael Castro", Publisher="The Melodic Writing", PublishYear=2011, IsBorrowed=true},
            new Book{BookID=4041, Title="Pirates And Blacksmiths" ,Author="Drew Hudson", Publisher="The Melodic Writing", PublishYear=2020, IsBorrowed=true},
            new Book{BookID=1045, Title="Tortoise Of Hope" ,Author="Rowan Baker", Publisher="Schmaltzy Entertainments", PublishYear=2011, IsBorrowed=false},
            new Book{BookID=3141, Title="Children And Giants" ,Author="Kelly Slater", Publisher="Schmaltzy Entertainments", PublishYear=1976, IsBorrowed=false},
            new Book{BookID=2021, Title="Enemies Of The Ancients" ,Author="Tristan Lambert", Publisher="The Acrobatic Robots", PublishYear=2011, IsBorrowed=false},
            new Book{BookID=2042, Title="Creator Of The Forsaken" ,Author="Nevada Romero", Publisher="Schmaltzy Entertainments", PublishYear=2021, IsBorrowed=true}
            };

            books.ForEach(book => { libraryContext.Books.Add(book); });
            libraryContext.SaveChanges();

            var borrows = new List<Borrow>
            {
                new Borrow{BorrowID=3310, MemberID= 2, BookID= 2042, BorrowDate=DateTime.Parse("2021-09-01"), BorrowDeadline=DateTime.Parse("2021-10-01")},
                new Borrow{BorrowID=8841, MemberID= 5, BookID= 4041, BorrowDate=DateTime.Parse("2021-07-15"), BorrowDeadline=DateTime.Parse("2021-08-15")},
                new Borrow{BorrowID=2766, MemberID= 2, BookID= 4022, BorrowDate=DateTime.Parse("2021-08-07"), BorrowDeadline=DateTime.Parse("2021-09-07")},
                new Borrow{BorrowID=5494, MemberID= 5, BookID= 9812, BorrowDate=DateTime.Parse("2021-09-14"), BorrowDeadline=DateTime.Parse("2021-10-14")},
                new Borrow{BorrowID=5825, MemberID= 7, BookID= 7634, BorrowDate=DateTime.Parse("2021-11-23"), BorrowDeadline=DateTime.Parse("2021-12-23")},
                new Borrow{BorrowID=8693, MemberID= 1, BookID= 1273, BorrowDate=DateTime.Parse("2021-10-09"), BorrowDeadline=DateTime.Parse("2021-11-09")},
                new Borrow{BorrowID=1926, MemberID= 8, BookID= 6543, BorrowDate=DateTime.Parse("2021-10-07"), BorrowDeadline=DateTime.Parse("2021-11-07")},
                new Borrow{BorrowID=9754, MemberID= 2, BookID= 1234, BorrowDate=DateTime.Parse("2021-09-05"), BorrowDeadline=DateTime.Parse("2021-10-05")}
            };

            borrows.ForEach(borrow => { libraryContext.Borrows.Add(borrow); });
            libraryContext.SaveChanges();
        }
    }
}
