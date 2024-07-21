using System.Linq;
namespace StoreView.BookStoreBasic
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books =
        {
            new Book(1, "Art of Programming"),
            new Book(2, "Refactoring"),
            new Book(3, "C Programming Lenguage"),
        };
        public Book[] GetAllByTitle(string titlePart)
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
            }
            return books.Where(book => book.Title.Contains(titlePart)).ToArray();
            
        }
    }
}
