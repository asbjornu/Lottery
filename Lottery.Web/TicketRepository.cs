namespace Lottery.Web;

public class TicketRepository
{
    private static readonly Dictionary<string, Ticket> Tickets;

    static TicketRepository()
    {
        var prefix = (char)Enumerable.Range('A', 'Z' - 'A' + 1).SelectRandom();
        Tickets = Enumerable
            .Range(1, 100)
            .Select(index => new Ticket(prefix, index))
            .ToDictionary(t => t.Number, t => t);
    }

    public IEnumerable<Ticket> GetTickets()
    {
        return Tickets.Values;
    }

    public Ticket GetTicket(string ticketId)
    {
        return Tickets[ticketId];
    }

    public Ticket Purchase(string ticketNumber, User user)
    {
        var ticket = Tickets[ticketNumber];

        if (ticket.PurchasedBy != null)
            throw new InvalidOperationException($"Ticket {ticketNumber} is taken by {ticket.PurchasedBy}.");

        ticket.PurchasedBy = user.Username;
        return ticket;
    }
}
