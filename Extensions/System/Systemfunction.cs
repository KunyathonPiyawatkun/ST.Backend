using Extensions.Common.STFunction;
using System.Drawing;

namespace ST_API.Extensions.SystemFunction
{
    /// <summary>
    /// SystemFunction
    /// </summary>
    public class SystemFunction
    {

        public static Image LoadBase64(string base64)
        {
            byte[] bytes = Convert.FromBase64String(base64);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        /// <summary>
        /// ใช้สำหรับการ Resize Image
        /// </summary>
        /// <param name="bmp">ภาพ Bitmap</param>
        /// <param name="width">ขนาดกว้างของภาพที่ต้องการ Resize</param>
        /// <param name="height">ขนาดความสูงของภาพที่ต้องการ Resize</param>
        public static Bitmap ResizeBitmap(Bitmap bmp, int? width, int? height)
        {
            int nWidth_new = 0;
            int nHeigth_new = 0;
            int nWidth_bmp = bmp.Width;
            int nHeigth_bmp = bmp.Height;
            if (width.HasValue && height.HasValue)
            {
                nWidth_new = width.Value;
                nHeigth_new = height.Value;
            }
            else if (width.HasValue && !height.HasValue)
            {
                nWidth_new = width.Value;
                nHeigth_new = nWidth_bmp != 0 ? (nHeigth_bmp * nWidth_new) / nWidth_bmp : nHeigth_bmp;
            }
            else if (!width.HasValue && height.HasValue)
            {
                nWidth_new = nHeigth_bmp != 0 ? (nWidth_bmp * nHeigth_new) / nHeigth_bmp : nWidth_bmp;
                nHeigth_new = height.Value;
            }
            Bitmap result = new Bitmap(nWidth_new, nHeigth_new);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, nWidth_new, nHeigth_new);
            }
            return result;
        }

        /// <summary>
        /// ใช้สำหรับการ Create Folder
        /// </summary>
        /// <param name="sPath">Path ที่ต้องการ  Create</param>
        /// <param name="_env">IHostEnvironment</param>
        public static void FolderCreate(string sPath, IHostEnvironment _env)
        {
            var path = STFunction.MapPath(sPath, _env);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        private static int nCountDel = 0; //จำนวนครั้งที่ Delete ไม่ได้เนื่องจากไฟล์ถูก Read อยู่

        /// <summary>
        /// ใช้สำหรับการ ลบไฟล์
        /// </summary>
        /// <param name="sPath">Path for delete</param>
        /// <param name="_env">IHostEnvironment</param>
        public static void deleteFile(string sPath, IHostEnvironment _env)
        {
            try
            {
                var path = STFunction.MapPath(sPath, _env);
                if (nCountDel <= 10)
                {
                    sPath = STFunction.Scan_CWE22_FullPathFile(path);
                    if (!string.IsNullOrEmpty(sPath) && File.Exists(sPath))
                    {
                        File.Delete(sPath);
                    }
                }
            }
            catch (System.Exception ex)
            {
                var x = ex.Message.ToString();
                if (x.Contains("The process cannot access the file"))
                {
                    nCountDel++;
                    Thread.Sleep(1000);
                    deleteFile(sPath, _env);
                }
            }
        }

        /// <summary>
        /// ใช้สำหรับการ ย้ายไฟล์
        /// </summary>
        /// <param name="TempPath">Path เก่าที่ต้องการย้าย</param>
        /// <param name="TruePath">Path ใหม่ที่ต้องการไปวาง</param>
        /// <param name="SysFileName">ชื่อไฟล์ในระบบ</param>
        /// <param name="_env">IHostEnvironment</param>
        public static void MoveFile(string TempPath, string TruePath, string SysFileName, IHostEnvironment _env)
        {
            FolderCreate(TruePath, _env);

            var ServerTempPath = STFunction.MapPath(TempPath, _env);
            var ServerTruePath = STFunction.MapPath(TruePath, _env);

            string FileTempPath = STFunction.Scan_CWE22_File(ServerTempPath, SysFileName);
            string FileTruePath = STFunction.Scan_CWE22_File(ServerTruePath, SysFileName);
            if (File.Exists(FileTempPath))
            {
                if (FileTempPath != FileTruePath)
                {
                    File.Move(FileTempPath, FileTruePath);
                }
            }
        }
        /// <summary>
        /// ใช้สำหรับการ คัดลอกไฟล์
        /// </summary>
        /// <param name="TempPath">Path เก่าที่ต้องการย้าย</param>
        /// <param name="TruePath">Path ใหม่ที่ต้องการไปวาง</param>
        /// <param name="SysFileName">ชื่อไฟล์ในระบบ</param>
        /// <param name="_env">IHostEnvironment</param>
        public static void CopyFile(string TempPath, string TruePath, string SysFileName, IHostEnvironment _env)
        {
            FolderCreate(TruePath, _env);

            var ServerTempPath = STFunction.MapPath(TempPath, _env);
            var ServerTruePath = STFunction.MapPath(TruePath, _env);

            string FileTempPath = STFunction.Scan_CWE22_File(ServerTempPath, SysFileName);
            string FileTruePath = STFunction.Scan_CWE22_File(ServerTruePath, SysFileName);
            if (File.Exists(FileTempPath))
            {
                if (FileTempPath != FileTruePath)
                {
                    if (File.Exists(FileTruePath))
                    {
                        //ถ้าชื่อไฟล์เหมือนกันมีอยู่แล้ว ลบแล้วคัดลอกมาใหม่
                        File.Delete(FileTruePath);
                        File.Copy(FileTempPath, FileTruePath);
                    }
                    else
                    {
                        File.Copy(FileTempPath, FileTruePath);
                    }
                }
            }
        }
        /// <summary>
        /// Get path File for display
        /// </summary>
        /// <param name="FilePath">Path file</param>
        /// <param name="SysFileName">ชื่อไฟล์ในระบบ</param>
        public static string? GetPathUploadFile(string FilePath, string SysFileName)
        {
            string? sFullPath = null;
            if (!string.IsNullOrEmpty(FilePath) && !string.IsNullOrEmpty(SysFileName))
            {
                string sPathWeb = STFunction.GetAppSettingJson("AppSetting:UrlSiteBackend");
                sFullPath = sPathWeb + "UploadFile/" + FilePath + "/" + SysFileName;
            }
            return sFullPath;
        }
        /// <summary>
        /// check have file name
        /// </summary>
        /// <param name="sPath">Path file</param>
        /// <param name="_env">IHostEnvironment</param>
        public static bool isCheckFile(string sPath, IHostEnvironment _env)
        {
            bool isHaveFile = false;
            var path = STFunction.MapPath(sPath, _env);
            if (File.Exists(path))
            {
                isHaveFile = true;
            }
            return isHaveFile;
        }
        /// <summary>
        /// check have Folder name
        /// </summary>
        /// <param name="sPath">Path file</param>
        /// <param name="_env">IHostEnvironment</param>
        public static bool isCheckFolder(string sPath, IHostEnvironment _env)
        {
            bool isHaveFolder = false;
            var path = STFunction.MapPath(sPath, _env);
            if (Directory.Exists(path))
            {
                isHaveFolder = true;
            }
            return isHaveFolder;
        }

        /// <summary>
        /// FontName_Export สไตล์ฟ้อน
        /// </summary>
        public static string FontName_Export = "Angsana New";
         /// <summary>
        /// FontSize_Export
        /// </summary>
        public static int FontSize_Export = 14;
         /// <summary>
        /// FontSize_Export_Head
        /// </summary>
        public static int FontSize_Export_Head = 16;
         /// <summary>
        /// Color_Head
        /// </summary>
        public static string Color_Head = "#004290";
         /// <summary>
        /// Color_Foot
        /// </summary>
        public static string Color_Foot = "#FFC000";

    }
}