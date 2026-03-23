public class VIPTicket : Ticket
{
    public bool Lounge { get; set; }
    public double Fee { get; set; }

    public VIPTicket(string movie, double price, bool lounge, double fee)
        : base(movie, price)
    {
        Lounge = lounge;
        Fee = fee;
    }

    public override double CalculateFinalPrice()
        => (BasePrice + Fee) * 1.14;

    public override string GetTypeName() => "VIP";
}