namespace Extensions.Common.STFunction
{
    /// <summary>
    /// ST Function
    /// </summary>
    public class STFunction
    {
        /// <summary>
        /// 
        /// </summary>
        public static string GetAppSettingJson(string GetParameter)
        {
            string Result = "";
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false);
            IConfigurationRoot configuration = builder.Build();
            IConfigurationSection section = configuration.GetSection(GetParameter);
            Result = section != null ? (section.Value + "") : "";
            return Result;
        }
        /// <summary>
        /// 
        /// </summary>
        public static string MapPath(string sPath, IHostEnvironment _env)
        {
            string sPathName = "";
            if (!FilePathHasInvalidChars(sPath))
            {
                // string sRootPath = (_env.IsDevelopment() ? "ClientApp\\build" : "wwwroot") + "\\UploadFile\\";
                bool isWindow = STFunction.GetAppSettingJson("AppSetting:MapPathToWindow") == "Y";
                string sRootPath = (_env.IsDevelopment() ? "wwwroot" : "wwwroot") + (isWindow ? "\\UploadFile\\" : "/UploadFile/");
                string sFolderName = Path.Combine(sRootPath, sPath);
                string baseFolder = Path.Combine(_env.ContentRootPath, sFolderName);
                string sFullPath = Path.GetFullPath(baseFolder);

                if (FilePathHasInvalidChars(baseFolder))
                {
                    return "Trying to read path outside of root";
                }

                if (!sFullPath.StartsWith(_env.ContentRootPath))
                {
                    return "Trying to read path outside of root";
                }

                sPathName = RemoveInvalidPathChars(baseFolder);
            }

            return sPathName;
        }
        /// <summary>
        /// 
        /// </summary>
        public static string Scan_CWE22_File(string pathName, string fileName)
        {
            string sPathFile = "";
            string sFileName = Path.GetFileName(fileName);
            if (!string.IsNullOrEmpty(pathName) && !string.IsNullOrEmpty(sFileName))
            {
                sPathFile = Path.Combine(pathName, fileName);
                string sPathSecurity = (sPathFile)
                .Replace("../", "")
                .Replace("..\\", "")
                .Replace("..", "")
                .Replace("/", "\\").Trim();

                Uri uriAddress2 = new Uri(sPathSecurity);
                if (!uriAddress2.IsFile)
                {
                    sPathFile = sPathSecurity;
                }
            }
            return sPathFile;
        }
        /// <summary>
        /// 
        /// </summary>
        public static string Scan_CWE22_FullPathFile(string pathFile)
        {
            string sPathSecurity = "";
            if (!string.IsNullOrEmpty(pathFile))
            {
                sPathSecurity = pathFile
                .Replace("../", "")
                .Replace("..\\", "")
                .Replace("..", "")
                .Replace("/", "\\").Trim();

                Uri uriAddress2 = new Uri(sPathSecurity);
                if (!uriAddress2.IsFile)
                {
                    sPathSecurity = "";
                }
            }
            return sPathSecurity;
        }
        /// <summary>
        /// 
        /// </summary>
        public static bool FilePathHasInvalidChars(string path)
        {
            return (!string.IsNullOrEmpty(path) && path.IndexOfAny(Path.GetInvalidPathChars()) >= 0);
        }
        /// <summary>
        /// 
        /// </summary>
        public static string RemoveInvalidPathChars(string filepath)
        {
            return !string.IsNullOrEmpty(filepath) ? string.Concat(filepath.Split(Path.GetInvalidPathChars())) : "";
        }
        /// <summary>
        /// 
        /// </summary>
        public static string RemoveUnsupportChar(string fileName)
        {
            if (fileName.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) > 0)
            {
                throw new Exception("Error");
            }

            fileName = fileName.Replace("'", "").Replace(";", "");

            return fileName;
        }
        /// <summary>
        /// 
        /// </summary>
        public static string RemoveUnsupportFolderChar(string fileName)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                string sPathFolder = "";
                string[] arrData = fileName.Split('/');
                foreach (var item in arrData)
                {
                    if (item.IndexOfAny(System.IO.Path.GetInvalidFileNameChars()) > 0)
                    {
                        throw new Exception("Error");
                    }
                    else
                    {
                        sPathFolder += "/" + item;
                    }
                }
                string sNewFoler = sPathFolder.Length > 0 ? sPathFolder.Remove(0, 1) : "";
                fileName = sNewFoler.Replace("'", "").Replace(";", "");
            }
            return fileName;
        }

        public static cReportFont GetReportFont(string sType)
        {
            cReportFont objFont = new cReportFont();
            if (sType == "docx" || sType == "pdf")
            {
                objFont.sFont = "Angsana New";
                objFont.nFontSize = 16;
            }
            else
            {
                objFont.sFont = "Tahoma";
                objFont.nFontSize = 12;
            }
            return objFont;
        }

        public class cReportFont
        {
            public string sFont { get; set; }
            public int nFontSize { get; set; }
        }
    }
}
