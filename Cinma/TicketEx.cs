namespace G_NET_33_OOP06;

public static class TicketExtensions
{
    public static string ToReceipt(this Ticket t)
    {
        return $@"
========== RECEIPT ==========
Movie    : {t.MovieName}
Type     : {t.GetType().Name}
Price    : {t.BasePrice}
Final    : {t.CalculateFinalPrice():F2}
Status   : {(t.IsBooked ? "Booked" : "Not Booked")}
=============================";
    }

    public static double TotalRevenue(this Ticket[] tickets)
    {
        return tickets.Sum(t => t.CalculateFinalPrice());
    }
}