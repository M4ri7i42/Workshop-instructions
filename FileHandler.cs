namespace Workshop_repo_1;

public class FileHandler
{
    private readonly string _filePathFacts = Path.Combine("data", "Facts.txt");
    
    public string GetRandomFact()
    {
        try
        {
            if (!File.Exists(_filePathFacts))
            {
                Console.WriteLine("Facts file not found. Contact Support.");
                return string.Empty;
            }
    
            string[] lines = File.ReadAllLines(_filePathFacts);
            int randomNumber = Random.Shared.Next(0, lines.Length);
            return lines[randomNumber];
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while reading the facts file: {ex.Message}");
            return string.Empty;
        }
        
    }
}