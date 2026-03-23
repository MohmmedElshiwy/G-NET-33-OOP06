public class IMAXTicket : Ticket
{
    public bool Is3D { get; set; }

    public IMAXTicket(string movie, double price, bool is3D)
        : base(movie, price)
    {
        Is3D = is3D;
    }

    public override double CalculateFinalPrice()
        => BasePrice * 1.14;

    public override string GetTypeName() => "IMAX";
}