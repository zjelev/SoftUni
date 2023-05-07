using Microsoft.AspNetCore.Mvc;
using WebApiMessages.Data;

namespace WebApiMessages.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly AppDbContext context;

        public MessagesController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Message>>> Index() 
        {
            return this.context.Messages
                .OrderBy(m => m.CreatedOn)
                .ToList();
        }

        [HttpPost(Name = "Create")]
        [Route("create")]
        public async Task<ActionResult> Create(MessageCreateBindingModel model)
        {
            Message message = new Message
            {
                Id = Guid.NewGuid().ToString(),
                Content = model.Content,
                User = model.User,
                CreatedOn = DateTime.UtcNow
            };

            await this.context.Messages.AddAsync(message);
            await this.context.SaveChangesAsync();
            return this.Ok();
        }
    }
}
