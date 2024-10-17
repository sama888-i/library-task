namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Book book1 = new Book(1, 25.5, "Ilahi Komediya",100, "Epic Poetry");
            Book book2 = new Book(2, 14.88, "Martin Eden", 50, "Literary fiction");
            Book book3 = new Book(3, 20, "Sefiller", 25, "Fiction");
            Book book4 = new Book(4, 48, "Narnia", 80, "Fantasy");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);




            Book[] filteredBooks = (library.GetFilteredBooks(15,30);
            
            foreach(var filteredBook in filteredBooks)
            {
                filteredBook.ShowInfo();

            }

        }
    }
}
