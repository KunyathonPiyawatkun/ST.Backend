using Extensions.Common.STResultAPI;

namespace ST_API.Models
{
    /// <summary>
    /// </summary>
    public class cWFHRequest
    {
        /// <summary>
        /// WFH ID
        /// </summary>
        public int? nWFHRequestID { get; set; }
    }

    /// <summary>
    /// </summary>
    public class cWFHRequestHistory
    {
        /// <summary>
        /// WFH ID
        /// </summary>
        public int nWFHID { get; set; }
        /// <summary>
        /// </summary>
        public int nFlowProcessID { get; set; }
        /// <summary>
        /// </summary>
        public int nApproveBy { get; set; }
        /// <summary>
        /// </summary>
        public DateTime dApprove { get; set; }
        /// <summary>
        /// </summary>
        public string? sRemark { get; set; }
    }

    /// <summary>
    /// </summary>
    public class cWFHFlow
    {
        /// <summary>
        /// </summary>
        public int nWFHID { get; set; }
        /// <summary>
        /// </summary>
        public int nRequesterID { get; set; }
        /// <summary>
        /// </summary>
        public int nRequesterPositionID { get; set; }
        /// <summary>
        /// </summary>
        public int nMode { get; set; }
        /// <summary>
        /// </summary>
        public List<cLineApprover>? lstApprover { get; set; }
        /// <summary>
        /// </summary>
        public string? sRemark { get; set; }
    }

    /// <summary>
    /// </summary>
    public class cLineApprover
    {
        /// <summary>
        /// </summary>
        public int nWFHID { get; set; }
        /// <summary>
        /// </summary>
        public int? nApproveID { get; set; }
        /// <summary>
        /// </summary>
        public int nPositionID { get; set; }
        /// <summary>
        /// </summary>
        public bool IsLineApprover { get; set; }
    }
    /// <summary>
    /// </summary>
    public class cResWFHFlow
    {
        /// <summary>
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// </summary>
        public string? sMessage { get; set; }
    }

    public class clcFilterWFH 
    {
        public string sType { get; set; }
        public string? sStart { get; set; }
        public string? sEnd { get; set; }
        public List<string>? listRequest { get; set; }
        public List<string>? listStatus { get; set; }

    }


    public class clcResultTableWFH : ResultAPI
    {
        public List<objResultTableWFH>? lstData { get; set; }
    }

    public class objResultTableWFH
    {
        public int No { get; set; }
        public int? sID { get; set; }
        public string sWFHDate { get; set; }
        public List<objTaskTable> lsitTask { get; set; }
        public string sRequestDate { get; set; }
        public string sRequester { get; set; }
        public string sWaitingBy { get; set; }
        public string sStatus { get; set; }
        public string sRemark { get; set; }

    }

    public class objTaskTable 
    {
        public string Project { get; set; }
        public decimal? Progress { get; set; }
        public string Name { get; set; }
        public decimal Manhour { get; set; }

    }

}