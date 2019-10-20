using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class MultipartTests
    {
        [Test]
        public void TestMultipartByteranges() => Assert.AreEqual("multipart/byteranges", MimeType.Multipart.Byteranges);
        [Test]
        public void TestMultipartEncrypted() => Assert.AreEqual("multipart/encrypted", MimeType.Multipart.Encrypted);
        [Test]
        public void TestMultipartFormData() => Assert.AreEqual("multipart/form-data", MimeType.Multipart.FormData);
        [Test]
        public void TestMultipartRelated() => Assert.AreEqual("multipart/related", MimeType.Multipart.Related);
    }
}