using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace OpenClosed.Tests
{
        [TestFixture]
        public class VideoTests {
        	
	        [Test]
	        public void VideoSummaryHasTitleYearAndDirector() {
		        Video video = new Video("Jaws", 1975, "Steven Spielberg");
		        Assert.AreEqual("Jaws, 1975, dir: Steven Spielberg", video.Summary);
	        }

        }
}
