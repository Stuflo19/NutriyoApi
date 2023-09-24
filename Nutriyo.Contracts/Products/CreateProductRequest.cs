namespace Nutriyo.Contracts.Products;

public class CreateProductRequest
{
    public CreateProductRequest(string name, List<string> barcodes, int weight, NutritionalInformation perHundredGrams)
    {
        Name = name;
        Barcodes = barcodes;
        Weight = weight;
        PerHundredGrams = perHundredGrams;
    }

    public string Name { get; }
    public List<string> Barcodes { get; }
    public int Weight  { get; }
    public NutritionalInformation PerHundredGrams { get; }
};