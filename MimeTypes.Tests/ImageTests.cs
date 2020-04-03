using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class ImageTests
    {
        [TestCase(MimeType.Image.Bmp, "image/bmp")]
        [TestCase(MimeType.Image.Gif, "image/gif")]
        [TestCase(MimeType.Image.Jpeg, "image/jpeg")]
        [TestCase(MimeType.Image.Png, "image/png")]
        [TestCase(MimeType.Image.SvgXml, "image/svg+xml")]
        [TestCase(MimeType.Image.Tiff, "image/tiff")]
        [TestCase(MimeType.Image.Webp, "image/webp")]
        public void AssertImageMimeTypeValue(string valueUnderTest, string expectedValue)
        {
            Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
        }
    }
}