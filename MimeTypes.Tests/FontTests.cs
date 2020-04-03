using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class FontTests
    {
        [TestCase(MimeType.Font.Collection, "font/collection")]
        [TestCase(MimeType.Font.Otf, "font/otf")]
        [TestCase(MimeType.Font.Sfnt, "font/sfnt")]
        [TestCase(MimeType.Font.Ttf, "font/ttf")]
        [TestCase(MimeType.Font.Woff, "font/woff")]
        [TestCase(MimeType.Font.Woff2, "font/woff2")]
        public void AssertFontMimeTypeValue(string valueUnderTest, string expectedValue)
        {
            Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
        }
    }
}