using System.Collections.Generic;
using System.Data;

namespace Extensions.Systems
{
    public class AllClass
    {

        #region Upload File
        public class ItemFileData
        {
            public int nID { get; set; }
            public string? sSaveToFileName { get; set; }
            public string? sSysFileName { get; set; }
            public string? sFileName { get; set; }
            public string? sFolderName { get; set; }
            public string? sSaveToPath { get; set; }
            public string? sSize { get; set; }
            public string? sUrl { get; set; }
            public bool IsNewFile { get; set; }
            public bool IsNew { get; set; }
            public bool IsCompleted { get; set; }
            public bool IsProgress { get; set; }
            public string? sMsg { get; set; }
            public string? sProgress { get; set; }
            public bool IsDelete { get; set; }
            public string? sFileType { get; set; }
            public bool IsNewTab { get; set; }
            public string? sFileLink { get; set; }
            public string? sPath { get; set; }
            public int? nSizeName { get; set; } //cal Size
            public string? sCropFileLink { get; set; }
            public string? sCropPath { get; set; }
        }

        // public class cFile
        // {
        //     public string? sFileID { get; set; }
        //     public int index { get; set; }
        //     public string sFolderName { get; set; }
        //     public string sFileName { get; set; }
        //     public string sSysFileName { get; set; }
        //     public string sSizeName { get; set; }
        //     public string sUrl { get; set; }
        //     public string sFileLink { get; set; }
        //     public string sRootURL { get; set; }
        //     public bool IsNew { get; set; }
        //     public bool IsComplete { get; set; }
        //     public string sFileType { get; set; }
        //     public bool IsNewTab { get; set; }
        //     public bool IsDelete { get; set; }
        //     public string? sProgress { get; set; }
        // }

        // public class DataFile
        // {
        //     public cFile fFile { get; set; }
        // }

        public class cParamCrop
        {
            public string? sOldPath { get; set; }
            public string? sBase64 { get; set; }
        }

        #endregion
        #region remove
        public class RequestRemove
		{
			public List<string>? lstRemove { get; set; }
			public string? sID { get; set; }
		}
        #endregion

       
    }
}