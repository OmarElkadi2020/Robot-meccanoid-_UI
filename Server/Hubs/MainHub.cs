using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace MeccaUI_THDxIOT.Server.Hubs
{
    public class MainHub : Hub
    {
        public async Task SendVolRec(string username,int Level)
        {
            await Clients.All.SendAsync("ReciveVolRec", username, Level);
        }
         
        public async Task SendChargeRec(bool IsCharging, int ChargeLevel)
        {
            await Clients.All.SendAsync("ReceiveChargeRec", IsCharging, ChargeLevel);
        }

        public async Task SendToElevatorTunnnel(int RobotState, int UserState , int ConnectionFlag)
        {
            await Clients.All.SendAsync("ReciveFromElevatorTunnnel",  RobotState, UserState , ConnectionFlag);
        }

        public async Task SendToEmotionsTunnel(int CurrentEmoCondition, int ControlFlag , int ConnectionFlag)
        {
            await Clients.All.SendAsync("ReciveFromEmotionsTunnel", CurrentEmoCondition, ControlFlag  , ConnectionFlag);
        }

        public override async Task OnConnectedAsync()
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, "SignalR Users");
            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            await Groups.RemoveFromGroupAsync(Context.ConnectionId, "SignalR Users");
            await base.OnDisconnectedAsync(exception);
        }

    }

}
