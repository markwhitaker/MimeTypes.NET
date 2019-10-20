using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class ApplicationTests
    {
        [Test]
        public void TestApplicationAtomXml() => Assert.AreEqual("application/atom+xml", MimeType.Application.AtomXml);
        [Test]
        public void TestApplicationAtomcatXml() => Assert.AreEqual("application/atomcat+xml", MimeType.Application.AtomcatXml);
        [Test]
        public void TestApplicationEcmascript() => Assert.AreEqual("application/ecmascript", MimeType.Application.Ecmascript);
        [Test]
        public void TestApplicationJavaArchive() => Assert.AreEqual("application/java-archive", MimeType.Application.JavaArchive);
        [Test]
        public void TestApplicationJavascript() => Assert.AreEqual("application/javascript", MimeType.Application.Javascript);
        [Test]
        public void TestApplicationJson() => Assert.AreEqual("application/json", MimeType.Application.Json);
        [Test]
        public void TestApplicationMp4() => Assert.AreEqual("application/mp4", MimeType.Application.Mp4);
        [Test]
        public void TestApplicationOctetStream() => Assert.AreEqual("application/octet-stream", MimeType.Application.OctetStream);
        [Test]
        public void TestApplicationPdf() => Assert.AreEqual("application/pdf", MimeType.Application.Pdf);
        [Test]
        public void TestApplicationPkcs10() => Assert.AreEqual("application/pkcs10", MimeType.Application.Pkcs10);
        [Test]
        public void TestApplicationPkcs7Mime() => Assert.AreEqual("application/pkcs7-mime", MimeType.Application.Pkcs7Mime);
        [Test]
        public void TestApplicationPkcs7Signature() => Assert.AreEqual("application/pkcs7-signature", MimeType.Application.Pkcs7Signature);
        [Test]
        public void TestApplicationPkcs8() => Assert.AreEqual("application/pkcs8", MimeType.Application.Pkcs8);
        [Test]
        public void TestApplicationPostscript() => Assert.AreEqual("application/postscript", MimeType.Application.Postscript);
        [Test]
        public void TestApplicationRdfXml() => Assert.AreEqual("application/rdf+xml", MimeType.Application.RdfXml);
        [Test]
        public void TestApplicationRssXml() => Assert.AreEqual("application/rss+xml", MimeType.Application.RssXml);
        [Test]
        public void TestApplicationRtf() => Assert.AreEqual("application/rtf", MimeType.Application.Rtf);
        [Test]
        public void TestApplicationSmilXml() => Assert.AreEqual("application/smil+xml", MimeType.Application.SmilXml);
        [Test]
        public void TestApplicationXFontOtf() => Assert.AreEqual("application/x-font-otf", MimeType.Application.XFontOtf);
        [Test]
        public void TestApplicationXFontTtf() => Assert.AreEqual("application/x-font-ttf", MimeType.Application.XFontTtf);
        [Test]
        public void TestApplicationXFontWoff() => Assert.AreEqual("application/x-font-woff", MimeType.Application.XFontWoff);
        [Test]
        public void TestApplicationXPkcs12() => Assert.AreEqual("application/x-pkcs12", MimeType.Application.XPkcs12);
        [Test]
        public void TestApplicationXShockwaveFlash() => Assert.AreEqual("application/x-shockwave-flash", MimeType.Application.XShockwaveFlash);
        [Test]
        public void TestApplicationXSilverlightApp() => Assert.AreEqual("application/x-silverlight-app", MimeType.Application.XSilverlightApp);
        [Test]
        public void TestApplicationXhtmlXml() => Assert.AreEqual("application/xhtml+xml", MimeType.Application.XhtmlXml);
        [Test]
        public void TestApplicationXml() => Assert.AreEqual("application/xml", MimeType.Application.Xml);
        [Test]
        public void TestApplicationXmlDtd() => Assert.AreEqual("application/xml-dtd", MimeType.Application.XmlDtd);
        [Test]
        public void TestApplicationXsltXml() => Assert.AreEqual("application/xslt+xml", MimeType.Application.XsltXml);
        [Test]
        public void TestApplicationXWwwFormUrlencoded() => Assert.AreEqual("application/x-www-form-urlencoded", MimeType.Application.XWwwFormUrlencoded);
        [Test]
        public void TestApplicationZip() => Assert.AreEqual("application/zip", MimeType.Application.Zip);
    }
}