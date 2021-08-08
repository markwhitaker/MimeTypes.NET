namespace Mainwave.MimeTypes
{
    public static partial class MimeType
    {
        /// <summary>
        /// MIME type constants for <c>image/*</c> types
        /// </summary>
        public static class Image
        {
            private const string Prefix = "image/";

            /// <summary>
            /// image/bmp
            /// </summary>
            public const string Bmp = Prefix + "bmp";

            /// <summary>
            /// image/gif
            /// </summary>
            public const string Gif = Prefix + "gif";

            /// <summary>
            /// image/jpeg
            /// </summary>
            public const string Jpeg = Prefix + "jpeg";

            /// <summary>
            /// image/png
            /// </summary>
            public const string Png = Prefix + "png";

            /// <summary>
            /// image/svg+xml
            /// </summary>
            public const string SvgXml = Prefix + "svg+xml";

            /// <summary>
            /// image/tiff
            /// </summary>
            public const string Tiff = Prefix + "tiff";

            /// <summary>
            /// image/webp
            /// </summary>
            public const string Webp = Prefix + "webp";
        }
    }
}
