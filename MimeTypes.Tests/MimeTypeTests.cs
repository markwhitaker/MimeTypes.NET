using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class MimeTypeTests
    {
        #region Application
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
        #endregion
        
        #region Audio
        [Test]
        public void TestAudioMidi() => Assert.AreEqual("audio/midi", MimeTypes.Audio.Midi);
        [Test]
        public void TestAudioMp4() => Assert.AreEqual("audio/mp4", MimeTypes.Audio.Mp4);
        [Test]
        public void TestAudioMpeg() => Assert.AreEqual("audio/mpeg", MimeTypes.Audio.Mpeg);
        [Test]
        public void TestAudioOgg() => Assert.AreEqual("audio/ogg", MimeTypes.Audio.Ogg);
        [Test]
        public void TestAudioWebm() => Assert.AreEqual("audio/webm", MimeTypes.Audio.Webm);
        [Test]
        public void TestAudioXAac() => Assert.AreEqual("audio/x-aac", MimeTypes.Audio.XAac);
        [Test]
        public void TestAudioXAiff() => Assert.AreEqual("audio/x-aiff", MimeTypes.Audio.XAiff);
        [Test]
        public void TestAudioXMpegurl() => Assert.AreEqual("audio/x-mpegurl", MimeTypes.Audio.XMpegurl);
        [Test]
        public void TestAudioXMsWma() => Assert.AreEqual("audio/x-ms-wma", MimeTypes.Audio.XMsWma);
        [Test]
        public void TestAudioXWav() => Assert.AreEqual("audio/x-wav", MimeTypes.Audio.XWav);
        #endregion
        
        #region Image
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
        #endregion

        #region Text
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
        #endregion

        #region Video
        [Test]
        public void TestVideoThreegpp() => Assert.AreEqual("video/3gpp", MimeTypes.Video.Threegpp);
        [Test]
        public void TestVideoH264() => Assert.AreEqual("video/h264", MimeTypes.Video.H264);
        [Test]
        public void TestVideoMp4() => Assert.AreEqual("video/mp4", MimeTypes.Video.Mp4);
        [Test]
        public void TestVideoMpeg() => Assert.AreEqual("video/mpeg", MimeTypes.Video.Mpeg);
        [Test]
        public void TestVideoOgg() => Assert.AreEqual("video/ogg", MimeTypes.Video.Ogg);
        [Test]
        public void TestVideoQuicktime() => Assert.AreEqual("video/quicktime", MimeTypes.Video.Quicktime);
        [Test]
        public void TestVideoWebm() => Assert.AreEqual("video/webm", MimeTypes.Video.Webm);
        #endregion
    }
}