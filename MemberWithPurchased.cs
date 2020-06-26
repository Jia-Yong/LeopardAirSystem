public class MemberWithPurchased : Person
{

    private string id;
    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    private string password;
    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    private string flight_purchased;
    public string Flight_purchased
    {
        get { return flight_purchased; }
        set { flight_purchased = value; }
    }

    private string flight_seat;
    public string Flight_seat
    {
        get { return flight_seat; }
        set { flight_seat = value; }
    }

    private double total_purchased;
    public double Total_purchased
    {
        get { return total_purchased; }
        set { total_purchased = value; }
    }

    private int points;
    public int Points
    {
        get { return points; }
        set { points = value; }
    }

    private string date_purchased;
    public string Date_purchased
    {
        get { return date_purchased; }
        set { date_purchased = value; }
    }

    private string time_purchased;
    public string Time_purchased
    {
        get { return time_purchased; }
        set { time_purchased = value; }
    }
    public MemberWithPurchased(string theName, string theIc, string theEmail,
                    string theGender, string theId, string thePassword,
                    string theFlightPurchased, string theFlight_seat,
                    double theTotal_purchased,
                    string theDate_purchased, string theTime_purchased,
                    int thePoints)
        : base(theName, theIc, theEmail, theGender)
    {
        id = theId;
        password = thePassword;
        flight_purchased = theFlightPurchased;
        flight_seat = theFlight_seat;
        total_purchased = theTotal_purchased;
        date_purchased = theDate_purchased;
        time_purchased = theTime_purchased;
        points = thePoints;
    }

}