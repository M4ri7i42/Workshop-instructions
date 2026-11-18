namespace Workshop_repo_1;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Override av ToString() för att få snygg utskrift
    
    public override string ToString()
    {
        return $"First Name: {FirstName}," +
               $"\nLast Name: {LastName}";
    }
}