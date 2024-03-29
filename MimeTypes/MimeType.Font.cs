namespace Mainwave.MimeTypes;

public static partial class MimeType
{
    /// <summary>
    /// MIME type constants for <c>font/*</c> types
    /// </summary>
    public static class Font
    {
        private const string Prefix = "font/";

        /// <summary>
        /// font/collection
        /// </summary>
        public const string Collection = Prefix + "collection";

        /// <summary>
        /// font/otf
        /// </summary>
        public const string Otf = Prefix + "otf";

        /// <summary>
        /// font/sfnt
        /// </summary>
        public const string Sfnt = Prefix + "sfnt";

        /// <summary>
        /// font/ttf
        /// </summary>
        public const string Ttf = Prefix + "ttf";

        /// <summary>
        /// font/woff
        /// </summary>
        public const string Woff = Prefix + "woff";

        /// <summary>
        /// font/woff2
        /// </summary>
        public const string Woff2 = Prefix + "woff2";
    }
}