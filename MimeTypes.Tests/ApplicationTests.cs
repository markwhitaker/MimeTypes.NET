using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class ApplicationTests
    {
        [Test]
        public void TestApplicationAtomXml() => Assert.AreEqual("application/atom+xml", MimeTypes.Application.AtomXml);
        [Test]
        public void TestApplicationAtomcatXml() => Assert.AreEqual("application/atomcat+xml", MimeTypes.Application.AtomcatXml);
        [Test]
        public void TestApplicationEcmascript() => Assert.AreEqual("application/ecmascript", MimeTypes.Application.Ecmascript);
        [Test]
        public void TestApplicationJavaArchive() => Assert.AreEqual("application/java-archive", MimeTypes.Application.JavaArchive);
        [Test]
        public void TestApplicationJavascript() => Assert.AreEqual("application/javascript", MimeTypes.Application.Javascript);
        [Test]
        public void TestApplicationJson() => Assert.AreEqual("application/json", MimeTypes.Application.Json);
        [Test]
        public void TestApplicationMp4() => Assert.AreEqual("application/mp4", MimeTypes.Application.Mp4);
        [Test]
        public void TestApplicationOctetStream() => Assert.AreEqual("application/octet-stream", MimeTypes.Application.OctetStream);
        [Test]
        public void TestApplicationPdf() => Assert.AreEqual("application/pdf", MimeTypes.Application.Pdf);
        [Test]
        public void TestApplicationPkcs10() => Assert.AreEqual("application/pkcs10", MimeTypes.Application.Pkcs10);
        [Test]
        public void TestApplicationPkcs7Mime() => Assert.AreEqual("application/pkcs7-mime", MimeTypes.Application.Pkcs7Mime);
        [Test]
        public void TestApplicationPkcs7Signature() => Assert.AreEqual("application/pkcs7-signature", MimeTypes.Application.Pkcs7Signature);
        [Test]
        public void TestApplicationPkcs8() => Assert.AreEqual("application/pkcs8", MimeTypes.Application.Pkcs8);
        [Test]
        public void TestApplicationPostscript() => Assert.AreEqual("application/postscript", MimeTypes.Application.Postscript);
        [Test]
        public void TestApplicationRdfXml() => Assert.AreEqual("application/rdf+xml", MimeTypes.Application.RdfXml);
        [Test]
        public void TestApplicationRssXml() => Assert.AreEqual("application/rss+xml", MimeTypes.Application.RssXml);
        [Test]
        public void TestApplicationRtf() => Assert.AreEqual("application/rtf", MimeTypes.Application.Rtf);
        [Test]
        public void TestApplicationSmilXml() => Assert.AreEqual("application/smil+xml", MimeTypes.Application.SmilXml);
        [Test]
        public void TestApplicationXFontOtf() => Assert.AreEqual("application/x-font-otf", MimeTypes.Application.XFontOtf);
        [Test]
        public void TestApplicationXFontTtf() => Assert.AreEqual("application/x-font-ttf", MimeTypes.Application.XFontTtf);
        [Test]
        public void TestApplicationXFontWoff() => Assert.AreEqual("application/x-font-woff", MimeTypes.Application.XFontWoff);
        [Test]
        public void TestApplicationXPkcs12() => Assert.AreEqual("application/x-pkcs12", MimeTypes.Application.XPkcs12);
        [Test]
        public void TestApplicationXShockwaveFlash() => Assert.AreEqual("application/x-shockwave-flash", MimeTypes.Application.XShockwaveFlash);
        [Test]
        public void TestApplicationXSilverlightApp() => Assert.AreEqual("application/x-silverlight-app", MimeTypes.Application.XSilverlightApp);
        [Test]
        public void TestApplicationXhtmlXml() => Assert.AreEqual("application/xhtml+xml", MimeTypes.Application.XhtmlXml);
        [Test]
        public void TestApplicationXml() => Assert.AreEqual("application/xml", MimeTypes.Application.Xml);
        [Test]
        public void TestApplicationXmlDtd() => Assert.AreEqual("application/xml-dtd", MimeTypes.Application.XmlDtd);
        [Test]
        public void TestApplicationXsltXml() => Assert.AreEqual("application/xslt+xml", MimeTypes.Application.XsltXml);
        [Test]
        public void TestApplicationXWwwFormUrlencoded() => Assert.AreEqual("application/x-www-form-urlencoded", MimeTypes.Application.XWwwFormUrlencoded);
        [Test]
        public void TestApplicationZip() => Assert.AreEqual("application/zip", MimeTypes.Application.Zip);
    }
}