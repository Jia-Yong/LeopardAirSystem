public abstract class Person
{
    protected string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    protected string ic;
    public string Ic
    {
        get { return ic; }
        set { ic = value; }
    }

    protected string email;
    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    protected string gender;
    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public Person(string theName, string theIc, string theEmail, string theGender)
    {
        name = theName;
        ic = theIc;
        email = theEmail;
        gender = theGender;
    }
}