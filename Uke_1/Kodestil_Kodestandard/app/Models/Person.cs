namespace app.Models;

public class Person
{

    public int PersonId{get;init;}
    public string Name
    {
        get;
        set
        {
            if (string.IsNullOrEmpty(value)) throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public int Age {get;private set;}
}
