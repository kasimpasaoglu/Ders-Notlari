using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    public async Task SendMessage(string UserName, string Message)
    {
        await Clients.All.SendAsync("ReceiveMessage", UserName, Message);
    }
}