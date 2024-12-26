using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

public class ChatMessage
{
    public string UserName { get; set; }
    public string Message { get; set; }
}


[ApiController]
[Route("api/[controller]")]
public class ChatController : ControllerBase
{
    private readonly IHubContext<ChatHub> _chatHubContext;
    public ChatController(IHubContext<ChatHub> chatHubContext)
    {
        _chatHubContext = chatHubContext;
    }


    [HttpPost]
    [Route("Send")]
    public async Task<IActionResult> SendMessage(ChatMessage chatMessage)
    {
        if (string.IsNullOrWhiteSpace(chatMessage.Message) || string.IsNullOrWhiteSpace(chatMessage.UserName))
        {
            return BadRequest("Invalid Message or Username");
        }
        await _chatHubContext.Clients.All.SendAsync("ReceiveMessage", chatMessage.UserName, chatMessage.Message);
        return Ok();
    }
}