using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class MultipartTests
    {
        [TestCase(MimeType.Multipart.Byteranges, "multipart/byteranges")]
        [TestCase(MimeType.Multipart.Encrypted, "multipart/encrypted")]
        [TestCase(MimeType.Multipart.FormData, "multipart/form-data")]
        [TestCase(MimeType.Multipart.Related, "multipart/related")]
        public void AssertMultipartMimeTypeValue(string valueUnderTest, string expectedValue)
        {
            Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
        }
    }
}