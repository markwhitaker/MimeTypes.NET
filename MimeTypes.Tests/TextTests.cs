using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class TextTests
    {
        [TestCase(MimeType.Text.Css, "text/css")]
        [TestCase(MimeType.Text.Csv, "text/csv")]
        [TestCase(MimeType.Text.Html, "text/html")]
        [TestCase(MimeType.Text.Javascript, "text/javascript")]
        [TestCase(MimeType.Text.Plain, "text/plain")]
        [TestCase(MimeType.Text.RichText, "text/richtext")]
        [TestCase(MimeType.Text.Sgml, "text/sgml")]
        [TestCase(MimeType.Text.Xml, "text/xml")]
        [TestCase(MimeType.Text.Yaml, "text/yaml")]
        public void AssertTextMimeTypeValue(string valueUnderTest, string expectedValue)
        {
            Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
        }
    }
}
