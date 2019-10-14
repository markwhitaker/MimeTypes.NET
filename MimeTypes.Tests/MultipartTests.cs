using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class MultipartTests
    {
        [Test]
        public void TestMultipartByteranges() => Assert.AreEqual("multipart/byteranges", MimeTypes.Multipart.Byteranges);
        [Test]
        public void TestMultipartEncrypted() => Assert.AreEqual("multipart/encrypted", MimeTypes.Multipart.Encrypted);
        [Test]
        public void TestMultipartFormData() => Assert.AreEqual("multipart/form-data", MimeTypes.Multipart.FormData);
        [Test]
        public void TestMultipartRelated() => Assert.AreEqual("multipart/related", MimeTypes.Multipart.Related);
    }
}