namespace Lottery.Web;

public class Ticket
{
    public Ticket(char prefix, int number)
    {
        Number = $"{prefix}{number:0000}";
    }

    public string Number { get; set; }

    public string? PurchasedBy { get; set; }
}
