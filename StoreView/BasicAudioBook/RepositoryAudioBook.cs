using System.Linq;
namespace StoreView.BasicAudioBook
{
    public class RepositoryAudioBook : IRepositoryAudioBook
    {
        private readonly AudioBook[] audioBooks =
            {

                new AudioBook(1,"New Time",2.67f),
                new AudioBook(2,"Old Time",1.67f),
                new AudioBook(3,"Middle Time",2.02f)

            };

        public AudioBook[] GetAllSound()
        {
            
            return audioBooks;

        }
    }
}
