using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class ImageTests
    {
        [Test]
        public void TestImageBmp() => Assert.AreEqual("image/bmp", MimeType.Image.Bmp);
        [Test]
        public void TestImageGif() => Assert.AreEqual("image/gif", MimeType.Image.Gif);
        [Test]
        public void TestImageJpeg() => Assert.AreEqual("image/jpeg", MimeType.Image.Jpeg);
        [Test]
        public void TestImagePng() => Assert.AreEqual("image/png", MimeType.Image.Png);
        [Test]
        public void TestImageSvgXml() => Assert.AreEqual("image/svg+xml", MimeType.Image.SvgXml);
        [Test]
        public void TestImageTiff() => Assert.AreEqual("image/tiff", MimeType.Image.Tiff);
        [Test]
        public void TestImageWebp() => Assert.AreEqual("image/webp", MimeType.Image.Webp);
    }
}