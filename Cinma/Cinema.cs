
namespace G_NET_33_OOP06;

public partial class Cinema
{
    private List<Ticket> tickets = new();

    public void Open()
    {
        Console.WriteLine("=== Cinema Opened ===");
        Console.WriteLine("Projector ON\n");
    }

    public void Close()
    {
        Console.WriteLine("\nProjector OFF");
        Console.WriteLine("=== Cinema Closed ===");
    }

    public void AddTicket(Ticket ticket)
    {
        tickets.Add(ticket);
    }

    public List<Ticket> GetTickets() => tickets;
}