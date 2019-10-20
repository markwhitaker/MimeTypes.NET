using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class TextTests
    {
        [Test]
        public void TestTextCss() => Assert.AreEqual("text/css", MimeType.Text.Css);
        [Test]
        public void TestTextCsv() => Assert.AreEqual("text/csv", MimeType.Text.Csv);
        [Test]
        public void TestTextHtml() => Assert.AreEqual("text/html", MimeType.Text.Html);
        [Test]
        public void TestTextPlain() => Assert.AreEqual("text/plain", MimeType.Text.Plain);
        [Test]
        public void TestTextRichText() => Assert.AreEqual("text/richtext", MimeType.Text.RichText);
        [Test]
        public void TestTextSgml() => Assert.AreEqual("text/sgml", MimeType.Text.Sgml);
        [Test]
        public void TestTextYaml() => Assert.AreEqual("text/yaml", MimeType.Text.Yaml);
    }
}