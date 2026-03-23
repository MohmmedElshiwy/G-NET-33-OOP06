public abstract class Ticket
{
    public string MovieName { get; set; }
    public double BasePrice { get; set; }
    public bool IsBooked { get; private set; }

    protected Ticket(string movieName, double basePrice)
    {
        MovieName = movieName;
        BasePrice = basePrice;
    }

    public abstract double CalculateFinalPrice();

    public virtual string GetTypeName() => "General";

    public void Book() => IsBooked = true;
    public void Cancel() => IsBooked = false;
}