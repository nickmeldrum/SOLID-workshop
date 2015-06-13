using System.Collections.Generic;

namespace OpenClosed
{
    public class Customer
    {

        private IList<Video> borrowedVideos = new List<Video>();

        public virtual bool IsAllowedToBorrow
        {
            get { return borrowedVideos.Count < 3; }
        }

        public virtual void BorrowVideo(Video video)
        {
            video.Borrow(this);
            borrowedVideos.Add(video);
        }

    }
}
