using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class ImageTests
    {
        [Test]
        public void TestImageBmp() => Assert.AreEqual("image/bmp", MimeTypes.Image.Bmp);
        [Test]
        public void TestImageGif() => Assert.AreEqual("image/gif", MimeTypes.Image.Gif);
        [Test]
        public void TestImageJpeg() => Assert.AreEqual("image/jpeg", MimeTypes.Image.Jpeg);
        [Test]
        public void TestImagePng() => Assert.AreEqual("image/png", MimeTypes.Image.Png);
        [Test]
        public void TestImageSvgXml() => Assert.AreEqual("image/svg+xml", MimeTypes.Image.SvgXml);
        [Test]
        public void TestImageTiff() => Assert.AreEqual("image/tiff", MimeTypes.Image.Tiff);
        [Test]
        public void TestImageWebp() => Assert.AreEqual("image/webp", MimeTypes.Image.Webp);
    }
}