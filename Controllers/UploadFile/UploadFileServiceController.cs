using Microsoft.AspNetCore.Mvc;
using Extensions.Systems;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using ST_API.Extensions.SystemFunction;
using Extensions.Common.STFunction;
namespace ST_API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UploadFileSeviceController : ControllerBase
    {
        private readonly IHostEnvironment _env;
        public UploadFileSeviceController(IHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> UploadFileToTemp(string? sFolderTemp, bool? isResize, int? nWidthResize, int? nHeigthResize, int nIndex, bool? IsCheckRecommendSize)
        {
            try
            {
                AllClass.ItemFileData? data = new AllClass.ItemFileData();
                if (HttpContext.Request.Form.Files.Count > 0)
                {
                    string filepath = "Temp/" + (!string.IsNullOrEmpty(sFolderTemp) ? sFolderTemp : "");
                    string sFileName, sSysFileName = "";
                    string sFileType = "";
                    for (int i = 0; i < HttpContext.Request.Form.Files.Count; i++)
                    {
                        IFormFile? file = HttpContext.Request.Form.Files[i];
                        sFileName = file.FileName;
                        //For Upload Folder
                        string[]? splitName = file.FileName.Contains("/") ? file.FileName.Split("/") : null;
                        string sFileNameFolder = splitName != null && splitName.Any() ? splitName[splitName.Length - 1] : file.FileName;
                        sSysFileName = DateTime.Now.ToString("ddMMyyyyHHmmffffff") + "_" + nIndex + "_" + sFileNameFolder;
                        //generate file name
                        GenFileName(ref sFileName, ref sSysFileName);
                        //check folder and create
                        SystemFunction.FolderCreate(filepath, _env);
                        if (SystemFunction.isCheckFolder(filepath, _env))
                        {
                            var sMapPath = STFunction.MapPath(filepath + "/" + sSysFileName, _env);
                            string sTypefile = Path.GetExtension(sMapPath).ToLower();
                            if (!Directory.Exists(sMapPath))
                            {
                                bool isPassResize = true;
                                ImageFormat? sExtemsionFile = sTypefile == ".jpeg" ? ImageFormat.Jpeg : sTypefile == ".jpg" ? ImageFormat.Jpeg : ImageFormat.Png;
                                //Check Image Only
                                List<string>? lstMimeTypeImage = new List<string>() { ".jpeg", ".jpg", ".png" };
                                if (isResize == true && lstMimeTypeImage.Contains(sTypefile))
                                {
                                    using (MemoryStream memoryStream = new MemoryStream())
                                    {
                                        await file.CopyToAsync(memoryStream);
                                        using (var Bitmap = (Bitmap)Image.FromStream(memoryStream))
                                        {
                                            int nWidth = Bitmap.Width;
                                            int nHeigth = Bitmap.Height;

                                            int nWidth_new = nWidth;
                                            int nHeight_new = nHeigth;

                                            // Cal width heigth
                                            if (nWidthResize.HasValue && !nHeigthResize.HasValue)
                                            {
                                                nWidth_new = nWidthResize.Value;
                                                nHeight_new = nWidth_new != 0 ? (nHeigth * nWidth_new) / nWidth : nHeigth;
                                            }
                                            else if (!nWidthResize.HasValue && nHeigthResize.HasValue)
                                            {
                                                nHeight_new = nHeigthResize.Value;
                                                nWidth_new = nHeight_new != 0 ? (nWidth * nHeight_new) / nHeigth : nWidth;
                                            }
                                            else if (nWidthResize.HasValue && nHeigthResize.HasValue)
                                            {
                                                nWidth_new = nWidthResize.Value;
                                                nHeight_new = nHeigthResize.Value;
                                            }


                                            if (nHeigthResize.HasValue)
                                            {
                                                //vertical
                                                if (nHeigthResize > nHeigth)
                                                {
                                                    isPassResize = false;
                                                    data.IsCompleted = false;
                                                    data.sMsg = "ความสูงของภาพไม่ถึงขนาดที่กำหนด";
                                                }
                                                else
                                                {
                                                    Bitmap newImage = SystemFunction.ResizeBitmap(Bitmap, nWidth_new, nHeight_new);
                                                    newImage.SetResolution(72, 72);
                                                    Image oImage = (Image)newImage;
                                                    SystemFunction.FolderCreate(filepath + "\\Editor", _env);
                                                    string? sMapPathEditor = STFunction.MapPath(filepath + "\\Editor\\" + sSysFileName, _env);
                                                    oImage.Save(sMapPathEditor, sExtemsionFile);
                                                }
                                            }
                                            else if (nWidthResize.HasValue && nWidthResize > nWidth)
                                            {
                                                //horizontal
                                                isPassResize = false;
                                                data.IsCompleted = false;
                                                data.sMsg = "ความกว้างของภาพไม่ถึงขนาดที่กำหนด";
                                                if (nWidthResize > nWidth)
                                                {
                                                    isPassResize = false;
                                                    data.IsCompleted = false;
                                                    data.sMsg = "ความกว้างของภาพไม่ถึงขนาดที่กำหนด";
                                                }
                                                else
                                                {
                                                    Bitmap newImage = SystemFunction.ResizeBitmap(Bitmap, nWidth_new, nHeight_new);
                                                    newImage.SetResolution(72, 72);
                                                    Image oImage = (Image)newImage;
                                                    SystemFunction.FolderCreate(filepath + "\\Editor", _env);
                                                    string? sMapPathEditor = STFunction.MapPath(filepath + "\\Editor\\" + sSysFileName, _env);
                                                    oImage.Save(sMapPathEditor, sExtemsionFile);
                                                }
                                            }
                                            else
                                            {
                                                Bitmap.SetResolution(72, 72);
                                                Image oImage = (Image)Bitmap;
                                                SystemFunction.FolderCreate(filepath + "\\Editor", _env);
                                                string? sMapPathEditor = STFunction.MapPath(filepath + "\\Editor\\" + sSysFileName, _env);
                                                oImage.Save(sMapPathEditor, sExtemsionFile);
                                            }
                                        }
                                    }
                                }else if(IsCheckRecommendSize.HasValue)
                                {
                                    using (MemoryStream memoryStream = new MemoryStream())
                                    {
                                        await file.CopyToAsync(memoryStream);
                                        using (var Bitmap = (Bitmap)Image.FromStream(memoryStream))
                                        {
                                            int nWidth = Bitmap.Width;
                                            int nHeigth = Bitmap.Height;


                                            if (nWidthResize.HasValue && nHeigthResize.HasValue && nHeigthResize > nHeigth && nWidthResize > nWidth)
                                            {
                                                    isPassResize = false;
                                                    data.IsCompleted = false;
                                                    data.sMsg = "ความกว้างและความสูงของภาพไม่ถึงขนาดที่กำหนด";
                                            }
                                            else if (nHeigthResize.HasValue && nHeigthResize > nHeigth)
                                            {
                                                //vertical
                                                if (nHeigthResize > nHeigth)
                                                {
                                                    isPassResize = false;
                                                    data.IsCompleted = false;
                                                    data.sMsg = "ความสูงของภาพไม่ถึงขนาดที่กำหนด";
                                                }
                                            }
                                            else if (nWidthResize.HasValue && nWidthResize > nWidth)
                                            {
                                                //horizontal
                                                isPassResize = false;
                                                data.IsCompleted = false;
                                                data.sMsg = "ความกว้างของภาพไม่ถึงขนาดที่กำหนด";
                                            }
                                        }
                                    }
                                }

                                if (isPassResize)
                                {
                                    using (FileStream? stream = new FileStream(sMapPath, FileMode.Create))
                                    {
                                        file.CopyTo(stream);
                                    }
                                    filepath = isPassResize && isResize == true ? filepath + "/Editor" : filepath;
                                    filepath = filepath.Replace("../", "");

                                    data.nID = 0;
                                    data.IsCompleted = true;
                                    data.sSaveToFileName = sSysFileName;
                                    data.sUrl = filepath + "/" + sSysFileName;
                                    data.sFileName = sFileNameFolder;
                                    data.sFileLink = SystemFunction.GetPathUploadFile(filepath, sSysFileName);
                                    data.sCropFileLink = SystemFunction.GetPathUploadFile(filepath, sSysFileName);
                                    data.IsNewFile = true;
                                    data.IsDelete = false;
                                    data.sFileType = sFileType;
                                    data.sPath = filepath;
                                    data.sCropPath = filepath;
                                    data.sMsg = "";
                                }
                            }
                            else
                            {
                                data.IsCompleted = false;
                                data.sMsg = "Error: Cannot create directory !";
                            }


                        }
                        else
                        {
                            data.IsCompleted = false;
                            data.sMsg = "Error: Cannot create directory !";
                        }
                    }
                }
                return Ok(data);
            }
            catch (Exception error)
            {
                return StatusCode(500, new { result = "", message = error }); //return BadRequest();
            }

            static void GenFileName(ref string sFileName, ref string sSysFileName)
            {
                //Check Is Folder
                string[]? arrSplit = sSysFileName.Split("/");
                if (arrSplit.Count() > 1) // Is Folder
                {
                    sSysFileName = arrSplit[1];
                    sFileName = arrSplit[1];
                }

                //Cut File NameR
                string[]? arrfilename = sFileName.Split('.');
                if (sFileName.Length > 100)
                {
                    sFileName = sFileName.Substring(0, 90) + "." + arrfilename[arrfilename.Length - 1];
                }

                //Cut System File Name
                sSysFileName = sSysFileName.Replace(" ", "_").Replace("(", "").Replace(")", "");
                string[]? arrSysfilename = sSysFileName.Split('.');
                if (sSysFileName.Length > 29)
                {
                    sSysFileName = sSysFileName.Substring(0, 24) + "." + arrSysfilename[arrSysfilename.Length - 1];
                }
            }
        }

        [HttpPost]
        [DisableRequestSizeLimit]
        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> CropImageUploadFile(AllClass.cParamCrop oParam)
        {
            try
            {
                AllClass.ItemFileData? data = new AllClass.ItemFileData();
                if (!string.IsNullOrEmpty(oParam.sOldPath) && !string.IsNullOrEmpty(oParam.sBase64))
                {
                    string[]? arrPath = oParam.sOldPath.Split("/");
                    string sSystemName = arrPath[arrPath.Length - 1];
                    string sPathFolder = oParam.sOldPath.Replace(sSystemName, "") + "Crop";

                    SystemFunction.FolderCreate(sPathFolder, _env);
                    if (SystemFunction.isCheckFolder(sPathFolder, _env))
                    {
                        var sMapPath = STFunction.MapPath(sPathFolder + "/" + sSystemName, _env);
                        if (SystemFunction.isCheckFile(sMapPath, _env))
                        {
                            SystemFunction.deleteFile(sMapPath, _env);
                        }
                        string? Base64 = oParam.sBase64.Split(",").Length > 0 ? oParam.sBase64.Split(",")[1] : null;
                        if(!string.IsNullOrEmpty(Base64))
                        {
                            Image? oImage = SystemFunction.LoadBase64(Base64);
                            string sTypefile = Path.GetExtension(sMapPath).ToLower();
                            ImageFormat? sExtemsionFile = sTypefile == ".jpeg" ? ImageFormat.Jpeg : sTypefile == ".jpg" ? ImageFormat.Jpeg : ImageFormat.Png;
                            oImage.Save(sMapPath, sExtemsionFile);

                            string filepath = sPathFolder.Replace("../", "");

                            data.IsCompleted = true;
                            data.sUrl = filepath + "/" + sSystemName;
                            data.sCropFileLink = SystemFunction.GetPathUploadFile(filepath, sSystemName);
                            data.sCropPath = filepath;
                            data.sMsg = "";
                        }
                        
                    }
                    else
                    {
                        data.IsCompleted = false;
                        data.sMsg = "Error: Cannot create directory !";
                    }
                }

                return Ok(data);
            }
            catch (Exception error)
            {
                return StatusCode(500, new { result = "", message = error }); //return BadRequest();
            }
        }

        [HttpPost]
        [IgnoreAntiforgeryToken]
        public IActionResult DeleteInTemp(string? sPath)
        {
            if (!string.IsNullOrEmpty(sPath))
            {
                SystemFunction.deleteFile(sPath, _env);
            }
            return Ok();
        }

        [HttpGet("delete")]
        public IActionResult DeleteFile(string sPath)
        {
            AllClass.ItemFileData data = new AllClass.ItemFileData();
            try
            {
                if (!string.IsNullOrEmpty(sPath))
                {
                    SystemFunction.deleteFile(sPath, _env);
                }
                data.IsCompleted = true;
                return Ok(data);
            }
            catch (Exception error)
            {
                return StatusCode(500, new { result = "", message = error });
            }
        }

    }
}