using ST.INFRA.Common;

namespace ST_API.Models.Global
{
    public class cUserAlert
    {
        public string? sUserID { get; set; }
        public string? sUserRole { get; set; }
        public string? sMessage { get; set; }
    }
    public class cSelectOption
    {
        public string? label { get; set; }

        public string? value { get; set; }

    }
    public class cRemoveTable : STGrid.PaginationData
    {
        public List<string>? lstID { get; set; } = new List<string>();
    }
}
