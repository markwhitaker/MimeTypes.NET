using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class TextTests
    {
        [Test]
        public void TestTextCss() => Assert.AreEqual("text/css", MimeTypes.Text.Css);
        [Test]
        public void TestTextCsv() => Assert.AreEqual("text/csv", MimeTypes.Text.Csv);
        [Test]
        public void TestTextHtml() => Assert.AreEqual("text/html", MimeTypes.Text.Html);
        [Test]
        public void TestTextPlain() => Assert.AreEqual("text/plain", MimeTypes.Text.Plain);
        [Test]
        public void TestTextRichText() => Assert.AreEqual("text/richtext", MimeTypes.Text.RichText);
        [Test]
        public void TestTextSgml() => Assert.AreEqual("text/sgml", MimeTypes.Text.Sgml);
        [Test]
        public void TestTextYaml() => Assert.AreEqual("text/yaml", MimeTypes.Text.Yaml);
    }
}