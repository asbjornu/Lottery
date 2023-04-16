namespace Lottery.Web;

public class TicketRepository
{
    private static readonly Ticket[] Tickets;

    static TicketRepository()
    {
        var prefix = (char)Enumerable.Range('A', 'Z' - 'A' + 1).SelectRandom();
        Tickets = Enumerable.Range(1, 100).Select(index => new Ticket(prefix, index)).ToArray();
    }

    public IEnumerable<Ticket> GetTickets()
    {
        return Tickets;
    }
}
