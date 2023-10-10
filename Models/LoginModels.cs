namespace ST_API.Models
{
    /// <summary>
    /// รับค่ามา Login
    /// </summary>
    public class LoginModels
    {
        /// <summary>
        /// User Name สำหรับ Log in
        /// </summary>
        public string? sUsername { get; set; }
        /// <summary>
        /// รหัสผ่าน
        /// </summary>
        public string? sSecureCode { get; set; }
        /// <summary>
        /// AD = Login AD
        /// </summary>
        public string? sMode { get; set; }
    }
    /// <summary>
    /// ส่งค่ากลับ
    /// </summary>
    public class ResultLogin
    {
        /// <response code="200">ผ่าน</response>
        public bool IsLoggedIn { get; set; }
        /// <summary>
        /// </summary>
        public string? token { get; set; }
        /// <summary>
        /// Name EN
        /// </summary>
        public string? sFullnameTH { get; set; }
        /// <summary>
        /// Name TH
        /// </summary>
        public string? sFullnameEN { get; set; }
        /// <summary>
        /// sNickname
        /// </summary>
        public string? sNickname { get; set; }
        /// <summary>
        /// Position
        /// </summary>
        public string? sPosition { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string? sEmail { get; set; }
    }
}
