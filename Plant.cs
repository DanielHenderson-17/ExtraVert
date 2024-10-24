public class Plant
{
    public string Species { get; set; }
    public int LightNeeds { get; set; }  // 1: Shade, 5: Full Sun
    public decimal AskingPrice { get; set; }
    public string City { get; set; }
    public string ZIP { get; set; }
    public bool Sold { get; set; }

    public Plant(string species, int lightNeeds, decimal askingPrice, string city, string zip, bool sold = false)
    {
        Species = species;
        LightNeeds = lightNeeds;
        AskingPrice = askingPrice;
        City = city;
        ZIP = zip;
        Sold = sold;
    }
}
