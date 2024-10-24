public class Program
{
    public static void Main()
    {
        // This displays a welcome message
        Console.WriteLine("Welcome to the Plant Store!");

        // This initialized the list of plants
        var plants = new List<Plant>
        {
            new Plant("Fern", 1, 12.99m, "Portland", "97201"),
            new Plant("Cactus", 5, 25.50m, "Phoenix", "85001"),
            new Plant("Orchid", 2, 15.75m, "Miami", "33101"),
            new Plant("Rose", 4, 22.10m, "Los Angeles", "90001"),
            new Plant("Sunflower", 5, 5.99m, "Austin", "73301")
        };

        // This displays the available plants
        Console.WriteLine("Available Plants:");
        for (int i = 0; i < plants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {plants[i].Species}");
        }
    }
}
