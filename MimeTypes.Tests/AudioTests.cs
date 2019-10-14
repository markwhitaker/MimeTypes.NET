using NUnit.Framework;

namespace Mainwave.MimeTypes.Tests
{
    [TestFixture]
    public class AudioTests
    {
        [Test]
        public void TestAudioMidi() => Assert.AreEqual("audio/midi", MimeTypes.Audio.Midi);
        [Test]
        public void TestAudioMp4() => Assert.AreEqual("audio/mp4", MimeTypes.Audio.Mp4);
        [Test]
        public void TestAudioMpeg() => Assert.AreEqual("audio/mpeg", MimeTypes.Audio.Mpeg);
        [Test]
        public void TestAudioOgg() => Assert.AreEqual("audio/ogg", MimeTypes.Audio.Ogg);
        [Test]
        public void TestAudioWav() => Assert.AreEqual("audio/wav", MimeTypes.Audio.Wav);
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
    }
}