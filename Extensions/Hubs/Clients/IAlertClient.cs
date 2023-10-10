using ST_API.Models.Global;
using System.Threading.Tasks;

namespace Alert.Api.Hubs.Clients
{
    public interface IAlertClient
    {
        Task ReceiveAlert(cUserAlert sID);
    }
}