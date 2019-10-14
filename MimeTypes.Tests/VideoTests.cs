using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class VideoTests
    {
        [Test]
        public void TestVideoThreegpp() => Assert.AreEqual("video/3gpp", MimeTypes.Video.Threegpp);
        [Test]
        public void TestVideoH264() => Assert.AreEqual("video/h264", MimeTypes.Video.H264);
        [Test]
        public void TestVideoMp4() => Assert.AreEqual("video/mp4", MimeTypes.Video.Mp4);
        [Test]
        public void TestVideoMpeg() => Assert.AreEqual("video/mpeg", MimeTypes.Video.Mpeg);
        [Test]
        public void TestVideoOgg() => Assert.AreEqual("video/ogg", MimeTypes.Video.Ogg);
        [Test]
        public void TestVideoQuicktime() => Assert.AreEqual("video/quicktime", MimeTypes.Video.Quicktime);
        [Test]
        public void TestVideoWebm() => Assert.AreEqual("video/webm", MimeTypes.Video.Webm);
    }
}