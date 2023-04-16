using Microsoft.AspNetCore.Mvc;

namespace Lottery.Web.Controllers;

[ApiController]
[Route("tickets")]
public class TicketController : ControllerBase
{
    private readonly ILogger<TicketController> logger;
    private readonly TicketRepository ticketRepository;
    private readonly UserRepository userRepository;

    public TicketController(TicketRepository ticketRepository, UserRepository userRepository, ILogger<TicketController> logger)
    {
        this.ticketRepository = ticketRepository;
        this.userRepository = userRepository;
        this.logger = logger;
    }

    [HttpGet(Name = "GetTickets")]
    public IEnumerable<Ticket> GetTickets()
    {
        return this.ticketRepository.GetTickets();
    }

    [HttpGet("/tickets/{ticketId}", Name = "GetTicket")]
    public Ticket GetTicket(string ticketId)
    {
        return this.ticketRepository.GetTicket(ticketId);
    }

    [HttpPost("/tickets/{ticketId}", Name = "PurchaseTicket")]
    public Ticket Purchase(string ticketId, [FromBody] int userId)
    {
        var user = this.userRepository.Get(userId);
        return this.ticketRepository.Purchase(ticketId, user);
    }
}
