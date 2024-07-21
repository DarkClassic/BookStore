namespace StoreView.BasicAudioBook
{
    public class AudioBook
    {
        int Id { get; }

        public string Title { get; }

        public float AudioLong { get; }

        public AudioBook(int id, string Title, float AudioLong)
        {
            Id = id;
            this.Title = Title;
            this.AudioLong = AudioLong;

        }
    }
}
