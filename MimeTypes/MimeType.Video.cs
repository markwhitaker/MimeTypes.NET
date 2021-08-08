namespace Mainwave.MimeTypes
{
    public static partial class MimeType
    {
        /// <summary>
        /// MIME type constants for <c>video/*</c> types
        /// </summary>
        public static class Video
        {
            private const string Prefix = "video/";

            /// <summary>
            /// video/3gpp
            /// </summary>
            public const string Threegpp = Prefix + "3gpp";

            /// <summary>
            /// video/h264
            /// </summary>
            public const string H264 = Prefix + "h264";

            /// <summary>
            /// video/mp4
            /// </summary>
            public const string Mp4 = Prefix + "mp4";

            /// <summary>
            /// video/mpeg
            /// </summary>
            public const string Mpeg = Prefix + "mpeg";

            /// <summary>
            /// video/ogg
            /// </summary>
            public const string Ogg = Prefix + "ogg";

            /// <summary>
            /// video/quicktime
            /// </summary>
            public const string Quicktime = Prefix + "quicktime";

            /// <summary>
            /// video/webm
            /// </summary>
            public const string Webm = Prefix + "webm";
        }
    }
}
