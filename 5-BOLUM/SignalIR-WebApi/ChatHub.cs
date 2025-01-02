using Microsoft.AspNetCore.SignalR;

public class ChatHub : Hub
{
    public async Task SendMessage(string User, string Message)
    {
        await Clients.All.SendAsync("ReceiveMessage", User, Message);
    }
}