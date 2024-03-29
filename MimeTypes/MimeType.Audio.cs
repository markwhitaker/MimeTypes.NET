namespace Mainwave.MimeTypes;

public static partial class MimeType
{
    /// <summary>
    /// MIME type constants for <c>audio/*</c> types
    /// </summary>
    public static class Audio
    {
        private const string Prefix = "audio/";

        /// <summary>
        /// audio/midi
        /// </summary>
        public const string Midi = Prefix + "midi";

        /// <summary>
        /// audio/mp4
        /// </summary>
        public const string Mp4 = Prefix + "mp4";

        /// <summary>
        /// audio/mpeg
        /// </summary>
        public const string Mpeg = Prefix + "mpeg";

        /// <summary>
        /// audio/ogg
        /// </summary>
        public const string Ogg = Prefix + "ogg";

        /// <summary>
        /// audio/opus
        /// </summary>
        public const string Opus = Prefix + "opus";

        /// <summary>
        /// audio/3gpp
        /// </summary>
        public const string Threegpp = Prefix + "3gpp";

        /// <summary>
        /// audio/3gpp2
        /// </summary>
        public const string Threegpp2 = Prefix + "3gpp2";

        /// <summary>
        /// audio/wav
        /// </summary>
        public const string Wav = Prefix + "wav";

        /// <summary>
        /// audio/webm
        /// </summary>
        public const string Webm = Prefix + "webm";

        /// <summary>
        /// audio/x-aac
        /// </summary>
        public const string XAac = Prefix + "x-aac";

        /// <summary>
        /// audio/x-aiff
        /// </summary>
        public const string XAiff = Prefix + "x-aiff";

        /// <summary>
        /// audio/x-midi
        /// </summary>
        public const string XMidi = Prefix + "x-midi";

        /// <summary>
        /// audio/x-mpegurl
        /// </summary>
        public const string XMpegurl = Prefix + "x-mpegurl";

        /// <summary>
        /// audio/x-ms-wma
        /// </summary>
        public const string XMsWma = Prefix + "x-ms-wma";

        /// <summary>
        /// audio/x-wav
        /// </summary>
        public const string XWav = Prefix + "x-wav";
    }
}
