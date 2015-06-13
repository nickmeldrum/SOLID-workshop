using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosed
{
    public class Customer
    {

        private IList<Video> borrowedVideos = new List<Video>();

        public bool IsAllowedToBorrow
        {
            get { return borrowedVideos.Count < 3; }
        }

        public void BorrowVideo(Video video)
        {
            video.Borrow(this);
            borrowedVideos.Add(video);
        }

    }
}
