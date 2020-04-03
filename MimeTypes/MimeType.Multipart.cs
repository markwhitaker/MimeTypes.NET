namespace Mainwave.MimeTypes
{
    public static partial class MimeType
    {
        /// <summary>
        /// MIME type constants for multipart types
        /// </summary>
        public static class Multipart
        {
            private const string Prefix = "multipart/";
            
            /// <summary>
            /// multipart/byteranges
            /// </summary>
            public const string Byteranges = Prefix + "byteranges";
            
            /// <summary>
            /// multipart/encrypted
            /// </summary>
            public const string Encrypted = Prefix + "encrypted";
            
            /// <summary>
            /// multipart/form-data
            /// </summary>
            public const string FormData = Prefix + "form-data";
            
            /// <summary>
            /// multipart/related
            /// </summary>
            public const string Related = Prefix + "related";
        }
    }
}