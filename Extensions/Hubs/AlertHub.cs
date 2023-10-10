using Alert.Api.Hubs.Clients;
using Microsoft.AspNetCore.SignalR;
namespace Alert.Api.Hubs
{
    public class AlertHub : Hub<IAlertClient>
    {
    }
}