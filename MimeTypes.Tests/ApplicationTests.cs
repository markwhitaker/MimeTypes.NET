using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class ApplicationTests
    {
        [TestCase(MimeType.Application.AtomXml, "application/atom+xml")]
        [TestCase(MimeType.Application.AtomcatXml, "application/atomcat+xml")]
        [TestCase(MimeType.Application.Ecmascript, "application/ecmascript")]
        [TestCase(MimeType.Application.JavaArchive, "application/java-archive")]
        [TestCase(MimeType.Application.Javascript, "application/javascript")]
        [TestCase(MimeType.Application.Json, "application/json")]
        [TestCase(MimeType.Application.Mp4, "application/mp4")]
        [TestCase(MimeType.Application.OctetStream, "application/octet-stream")]
        [TestCase(MimeType.Application.Pdf, "application/pdf")]
        [TestCase(MimeType.Application.Pkcs10, "application/pkcs10")]
        [TestCase(MimeType.Application.Pkcs7Mime, "application/pkcs7-mime")]
        [TestCase(MimeType.Application.Pkcs7Signature, "application/pkcs7-signature")]
        [TestCase(MimeType.Application.Pkcs8, "application/pkcs8")]
        [TestCase(MimeType.Application.Postscript, "application/postscript")]
        [TestCase(MimeType.Application.RdfXml, "application/rdf+xml")]
        [TestCase(MimeType.Application.RssXml, "application/rss+xml")]
        [TestCase(MimeType.Application.Rtf, "application/rtf")]
        [TestCase(MimeType.Application.SmilXml, "application/smil+xml")]
        [TestCase(MimeType.Application.XFontOtf, "application/x-font-otf")]
        [TestCase(MimeType.Application.XFontTtf, "application/x-font-ttf")]
        [TestCase(MimeType.Application.XFontWoff, "application/x-font-woff")]
        [TestCase(MimeType.Application.XPkcs12, "application/x-pkcs12")]
        [TestCase(MimeType.Application.XShockwaveFlash, "application/x-shockwave-flash")]
        [TestCase(MimeType.Application.XSilverlightApp, "application/x-silverlight-app")]
        [TestCase(MimeType.Application.XhtmlXml, "application/xhtml+xml")]
        [TestCase(MimeType.Application.Xml, "application/xml")]
        [TestCase(MimeType.Application.XmlDtd, "application/xml-dtd")]
        [TestCase(MimeType.Application.XsltXml, "application/xslt+xml")]
        [TestCase(MimeType.Application.XWwwFormUrlencoded, "application/x-www-form-urlencoded")]
        [TestCase(MimeType.Application.Zip, "application/zip")]
        public void AssertApplicationMimeTypeValue(string valueUnderTest, string expectedValue)
        {
            Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
        }
    }
}