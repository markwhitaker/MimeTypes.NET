using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class VideoTests
    {
        [Test]
        public void TestVideoThreegpp() => Assert.AreEqual("video/3gpp", MimeType.Video.Threegpp);
        [Test]
        public void TestVideoH264() => Assert.AreEqual("video/h264", MimeType.Video.H264);
        [Test]
        public void TestVideoMp4() => Assert.AreEqual("video/mp4", MimeType.Video.Mp4);
        [Test]
        public void TestVideoMpeg() => Assert.AreEqual("video/mpeg", MimeType.Video.Mpeg);
        [Test]
        public void TestVideoOgg() => Assert.AreEqual("video/ogg", MimeType.Video.Ogg);
        [Test]
        public void TestVideoQuicktime() => Assert.AreEqual("video/quicktime", MimeType.Video.Quicktime);
        [Test]
        public void TestVideoWebm() => Assert.AreEqual("video/webm", MimeType.Video.Webm);
    }
}