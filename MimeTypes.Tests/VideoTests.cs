using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests;

[TestFixture]
public class VideoTests
{
    [TestCase(MimeType.Video.H264, "video/h264")]
    [TestCase(MimeType.Video.Mp2t, "video/mp2t")]
    [TestCase(MimeType.Video.Mp4, "video/mp4")]
    [TestCase(MimeType.Video.Mpeg, "video/mpeg")]
    [TestCase(MimeType.Video.Ogg, "video/ogg")]
    [TestCase(MimeType.Video.Quicktime, "video/quicktime")]
    [TestCase(MimeType.Video.Threegpp, "video/3gpp")]
    [TestCase(MimeType.Video.Threegpp2, "video/3gpp2")]
    [TestCase(MimeType.Video.Webm, "video/webm")]
    [TestCase(MimeType.Video.XMsvideo, "video/x-msvideo")]
    public void AssertVideoMimeTypeValue(string valueUnderTest, string expectedValue)
    {
        Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
    }
}
