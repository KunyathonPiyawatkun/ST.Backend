using System.Text.Json;
using Extensions.Common.STResultAPI;

namespace ST_API.Models
{
    /// <summary>
    /// ItemBreadCrumb
    /// </summary>
    public class cItemBreadCrumb
    {
        /// <summary>
        /// Key
        /// </summary>
        public string? Key { get; set; }
        /// <summary>
        /// Item Name
        /// </summary>
        public string? ItemName { get; set; }
        /// <summary>
        /// Icon
        /// </summary>
        public string? sIcon { get; set; }
        /// <summary>
        /// URL
        /// </summary>
        public string? sURL { get; set; }
        /// <summary>
        /// Level
        /// </summary>
        public int? nLevel { get; set; }
        /// <summary>
        /// Show in Display
        /// </summary>
        public bool IsDisplay { get; set; }
    }

    /// <summary>
    /// Bredcrumb
    /// </summary>
    public class clsBredcrumb : ResultAPI
    {
        /// <summary>
        /// lstBremcrumb
        /// </summary>
        public List<cItemBreadCrumb>? lstBremcrumb { get; set; }

    }

    /// <summary>
    /// Bredcrumb
    /// </summary>
    public class ResponseMenu : ResultAPI
    {
        /// <summary>
        /// List Menu
        /// </summary>
        public List<cItemMenu>? lstMenu { get; set; }

    }

    /// <summary>
    /// ItemMenu
    /// </summary>
    public class cItemMenu
    {
        /// <summary>
        /// Key
        /// </summary>
        public string? sKey { get; set; }
        /// <summary>
        /// Menu ID
        /// </summary>
        public string? sMenuID { get; set; }
        /// <summary>
        /// Menu Name
        /// </summary>
        public string? sMenuName { get; set; }
        /// <summary>
        /// URL
        /// </summary>
        public string? sURL { get; set; }
        /// <summary>
        /// Icon
        /// </summary>
        public string? sIcon { get; set; }
        /// <summary>
        /// Level
        /// </summary>
        public int? nLevel { get; set; }
        /// <summary>
        /// Show in Display
        /// </summary>
        public bool IsDisplay { get; set; }
        /// <summary>
        /// List Children
        /// </summary>
        public List<cItemMenu>? lstChildren { get; set; }
    }
}
