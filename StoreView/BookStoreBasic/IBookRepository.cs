namespace StoreView.BookStoreBasic
{
    public interface IBookRepository
    {
        Book[] GetAllByTitle(string titlePart);
    }
}
