using Microsoft.AspNetCore.Mvc;

namespace Lottery.Web.Controllers;

[ApiController]
[Route("tickets")]
public class TicketController : ControllerBase
{
    private readonly ILogger<TicketController> logger;
    private readonly TicketRepository ticketRepository;

    public TicketController(TicketRepository ticketRepository, ILogger<TicketController> logger)
    {
        this.ticketRepository = ticketRepository;
        this.logger = logger;
    }

    [HttpGet(Name = "GetTickets")]
    public IEnumerable<Ticket> Get()
    {
        return this.ticketRepository.GetTickets();
    }
}
