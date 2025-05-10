using help.form.assistant.Domain;
using help_form_assistant.Application;
using Microsoft.AspNetCore.Mvc;
using src.Web.DTO;

namespace help_form_assistant.Controllers
{
    [ApiController]
    [Route("chat", Name = "chat")]
    public class ChatController : ControllerBase
    {
        private readonly ILogger<ChatController> _logger;
        private readonly IChatService _chatService;

        public ChatController(ILogger<ChatController> logger, ChatService chatService)
        {
            _logger = logger;
            _chatService = chatService;
        }

        [HttpGet("sessions/{seassionId}")]
        public IActionResult GetSeassion(string seassionId)
        {
            return Ok(new { seassionId });
        }

        [HttpPost("sessions")]
        public IActionResult CreateSeassion(ChatSeassionCreateDTO chatSeassionCreateDTO)
        {
            return Ok(chatSeassionCreateDTO);
        }

        [HttpPost("messages")]
        public IActionResult SendMessage()
        {
            return Ok();
        }
    }
}