public class MemberWithoutPurchased : Person
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

    private int points;
    public int Points
    {
        get { return points; }
        set { points = value; }
    }
    public MemberWithoutPurchased(string theName, string theIc, string theEmail,
                    string theGender, string theId, string thePassword,
                    int thePoints)
        : base(theName, theIc, theEmail, theGender)
    {
        id = theId;
        password = thePassword;
        points = thePoints;
    }

}