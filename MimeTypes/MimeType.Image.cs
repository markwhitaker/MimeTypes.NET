namespace Mainwave.MimeTypes;

public static partial class MimeType
{
    /// <summary>
    /// MIME type constants for <c>image/*</c> types
    /// </summary>
    public static class Image
    {
        private const string Prefix = "image/";

        /// <summary>
        /// image/avif
        /// </summary>
        public const string Avif = Prefix + "avif";

        /// <summary>
        /// image/bmp
        /// </summary>
        public const string Bmp = Prefix + "bmp";

        /// <summary>
        /// image/gif
        /// </summary>
        public const string Gif = Prefix + "gif";

        /// <summary>
        /// image/jp2
        /// </summary>
        public const string Jp2 = Prefix + "jp2";

        /// <summary>
        /// image/jpeg
        /// </summary>
        public const string Jpeg = Prefix + "jpeg";
        
        /// <summary>
        /// image/jpm
        /// </summary>
        public const string Jpm = Prefix + "jpm";

        /// <summary>
        /// image/jpx
        /// </summary>
        public const string Jpx = Prefix + "jpx";

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
        /// image/vnd.microsoft.icon
        /// </summary>
        public const string VndMicrosoftIcon = Prefix + "vnd.microsoft.icon";

        /// <summary>
        /// image/webp
        /// </summary>
        public const string Webp = Prefix + "webp";
    }
}