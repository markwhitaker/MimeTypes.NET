using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class AudioTests
    {
        [TestCase(MimeType.Audio.Midi, "audio/midi")]
        [TestCase(MimeType.Audio.Mp4, "audio/mp4")]
        [TestCase(MimeType.Audio.Mpeg, "audio/mpeg")]
        [TestCase(MimeType.Audio.Ogg, "audio/ogg")]
        [TestCase(MimeType.Audio.Wav, "audio/wav")]
        [TestCase(MimeType.Audio.Webm, "audio/webm")]
        [TestCase(MimeType.Audio.XAac, "audio/x-aac")]
        [TestCase(MimeType.Audio.XAiff, "audio/x-aiff")]
        [TestCase(MimeType.Audio.XMpegurl, "audio/x-mpegurl")]
        [TestCase(MimeType.Audio.XMsWma, "audio/x-ms-wma")]
        [TestCase(MimeType.Audio.XWav, "audio/x-wav")]
        public void AssertAudioMimeTypeValue(string valueUnderTest, string expectedValue)
        {
            Assert.That(valueUnderTest, Is.EqualTo(expectedValue));
        }
    }
}