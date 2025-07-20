namespace task03
{
    class Library
    {
        List<Book> books;

        public Library(List<Book> books)
        {
            this.books = books;
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public bool BorrowBook(string isbn)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn && books[i].availability)
                {
                    books[i].availability = false;
                    Console.WriteLine($"You have borrowed: {books[i].title}");
                    return true;
                }
            }
            Console.WriteLine("Book not available for borrowing.");
            return false;
        }

        public bool ReturnBook(string isbn)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ISBN == isbn && books[i].availability == false)
                {
                    books[i].availability = true;
                    Console.WriteLine($"You have return: {books[i].title}");
                    return true;
                }
            }
            Console.WriteLine("Write a correct ISBN.");
            return false;
        }



        public void SearchBook(string authorOrTitle)
        {
            if (books.Count > 0)
            {

                for (int i = 0; i < books.Count; i++)
                {
                    Book book = books[i];

                    if (book.title.ToLower().Contains(authorOrTitle.ToLower()) ||
                        book.author.ToLower().Contains(authorOrTitle.ToLower()))
                    {
                        Console.WriteLine($"{book.title} by {book.author} - {(book.availability ? "Available" : "Not Available")}");

                    }
                }
            }

            else
                Console.WriteLine($"No books found matching: {authorOrTitle}");

        }
        public void ShowBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("There is no book You can add");
            }
            else
            {
                for (int i = 0; i < books.Count; i++)

                    Console.WriteLine($"{books[i].title} - {(books[i].availability ? "Available" : "Not Available")}");
            }
        }

    }
    class Book
    {
        public string title;
        public string author;
        public string ISBN;
        public bool availability = true;
        public Book(string title, string author, string ISBN, bool availability = true)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.availability = availability;
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {


            bool status = true;
            List<Book> books = new List<Book>();
            Library library = new Library(books);


            do
            {
                Console.WriteLine("A - Add book");
                Console.WriteLine("S - Search book");
                Console.WriteLine("B - Borrow book");
                Console.WriteLine("R - Return  book");
                Console.WriteLine("L - Show book in library");
                Console.WriteLine("Q - Quit");

                char letter = Convert.ToChar(Console.ReadLine().ToUpper());
                switch (letter)
                {
                    case 'A':

                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author name: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();

                        library.AddBook(new Book(title, author, isbn));
                        break;
                    case 'S':
                        Console.Write("Enter title or author to search: ");
                        string search = Console.ReadLine();
                        library.SearchBook(search);
                        break;
                    case 'B':
                        Console.Write("Enter ISBN to borrow: ");
                        string borrowIsbn = Console.ReadLine();
                        library.BorrowBook(borrowIsbn);
                        break;

                    case 'R':
                        Console.Write("Enter ISBN to return: ");
                        string returnIsbn = Console.ReadLine();
                        library.ReturnBook(returnIsbn);

                        break;
                    case 'L':

                        library.ShowBooks();

                        break;
                    case 'Q':
                        status = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Character");
                        break;

                }
            }
            while (status);




        }
    }
}
