namespace OpenClosed
{
    public class VideoWithRating : Video
    {
        public VideoWithRating(string title, int year, string director, int rating) : base(title, year, director)
        {
            this.Rating = rating;
        }

        public int Rating { get; private set; }
    }
}