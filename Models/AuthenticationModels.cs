namespace ST_API.Models.AuthenticationModels
{
    /// <summary>
    /// </summary>
    public class TokenJWTSecret
    {
        /// <summary>
        /// </summary>
        public int? nUserID { get; set; }
        /// <summary>
        /// </summary>
        public int? nPositionID { get; set; }
        /// <summary>
        /// </summary>
        public string? sUserCode { get; set; }
        /// <summary>
        /// </summary>
        public string? sEmail { get; set; }
        /// <summary>
        /// </summary>
        public string? sFullnameTH { get; set; }
        /// <summary>
        /// </summary>
        public string? sFullnameEN { get; set; }
        /// <summary>
        /// </summary>
        public string? sPositoion { get; set; }
        /// <summary>
        /// </summary>
        public string? sIssuer { get; set; }
        /// <summary>
        /// </summary>
        public string? sAudience { get; set; }
        /// <summary>
        /// </summary>
        public DateTime? dTimeout { get; set; }
        /// <summary>
        /// </summary>
        public string? sSecretKey { get; set; }
    }

    /// <summary>
    /// </summary>
    public partial class JwtClaimTypes
    {
        /// <summary>
        /// </summary>
        public static string USER_ID { get { return "USER_ID"; } }
        /// <summary>
        /// </summary>
        public static string USER_CODE { get { return "USER_CODE"; } }
        /// <summary>
        /// </summary>
        public static string EMAIL { get { return "EMAIL"; } }
        /// <summary>
        /// </summary>
        public static string FULLNAME { get { return "FULLNAME"; } }
    }
}
