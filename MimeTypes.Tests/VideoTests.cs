using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class VideoTests
    {
        [TestCase(MimeType.Video.Threegpp, "video/3gpp")]
        [TestCase(MimeType.Video.H264, "video/h264")]
        [TestCase(MimeType.Video.Mp4, "video/mp4")]
        [TestCase(MimeType.Video.Mpeg, "video/mpeg")]
        [TestCase(MimeType.Video.Ogg, "video/ogg")]
        [TestCase(MimeType.Video.Quicktime, "video/quicktime")]
        [TestCase(MimeType.Video.Webm, "video/webm")]
        public void AssertVideoMimeTypeValue(string valueUnderTest, string expectedValue)
        {
            Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
        }
    }
}