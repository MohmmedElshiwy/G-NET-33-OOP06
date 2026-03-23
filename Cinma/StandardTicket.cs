public class StandardTicket : Ticket
{
    public string Seat { get; set; }

    public StandardTicket(string movie, double price, string seat)
        : base(movie, price)
    {
        Seat = seat;
    }

    public override double CalculateFinalPrice()
        => BasePrice * 1.14;

    public override string GetTypeName() => "Standard";
}