namespace Workshop_repo_1;

public class RandomFact
{ 
    private FileHandler _file = new FileHandler();
    public string RandomFactGenerator()
    {
        return _file.GetRandomFact();
    }
}