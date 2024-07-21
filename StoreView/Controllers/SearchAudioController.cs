using Microsoft.AspNetCore.Mvc;
using StoreView.BasicAudioBook;
using StoreView.BookStoreBasic;

namespace StoreView.Controllers
{
    public class SearchAudioController : Controller
    {
        private readonly IRepositoryAudioBook repositoryAudioBook;

        public SearchAudioController(IRepositoryAudioBook repositoryAudioBook)
        {
            this.repositoryAudioBook = repositoryAudioBook;
        }
        public IActionResult Index()
        {
            AudioBook[] audioBook = repositoryAudioBook.GetAllSound();

            return View(audioBook);
        }
    }
}
