using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class AudioTests
    {
        [Test]
        public void TestAudioMidi() => Assert.AreEqual("audio/midi", MimeType.Audio.Midi);
        [Test]
        public void TestAudioMp4() => Assert.AreEqual("audio/mp4", MimeType.Audio.Mp4);
        [Test]
        public void TestAudioMpeg() => Assert.AreEqual("audio/mpeg", MimeType.Audio.Mpeg);
        [Test]
        public void TestAudioOgg() => Assert.AreEqual("audio/ogg", MimeType.Audio.Ogg);
        [Test]
        public void TestAudioWav() => Assert.AreEqual("audio/wav", MimeType.Audio.Wav);
        [Test]
        public void TestAudioWebm() => Assert.AreEqual("audio/webm", MimeType.Audio.Webm);
        [Test]
        public void TestAudioXAac() => Assert.AreEqual("audio/x-aac", MimeType.Audio.XAac);
        [Test]
        public void TestAudioXAiff() => Assert.AreEqual("audio/x-aiff", MimeType.Audio.XAiff);
        [Test]
        public void TestAudioXMpegurl() => Assert.AreEqual("audio/x-mpegurl", MimeType.Audio.XMpegurl);
        [Test]
        public void TestAudioXMsWma() => Assert.AreEqual("audio/x-ms-wma", MimeType.Audio.XMsWma);
        [Test]
        public void TestAudioXWav() => Assert.AreEqual("audio/x-wav", MimeType.Audio.XWav);
    }
}