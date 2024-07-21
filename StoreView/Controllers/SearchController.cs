
using Microsoft.AspNetCore.Mvc;
using StoreView.BookStoreBasic;

namespace StoreView.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBookRepository bookRepository;

        public SearchController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IActionResult Index(string query)
        {
            Book[] books = bookRepository.GetAllByTitle(query);

            return View(books);
        }
        
    }
}
