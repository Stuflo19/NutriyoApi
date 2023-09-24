using Nutriyo.Contracts.Products;

namespace Nutriyo.Models.Products;

public class Product
{
    private Product(Guid id, string name, List<string> barcodes, int weight, DateTime lastUpdated, NutritionalInformation perHundredGrams, NutritionalInformation perPacket)
    {
        Name = name;
        Barcodes = barcodes;
        LastUpdated = lastUpdated;
        Id = id;
        PerHundredGrams = perHundredGrams;
        PerPacket = perPacket;
        Weight = weight;
    }

    public static Product From(CreateProductRequest request) => new(
        new Guid(),
        request.Name,
        request.Barcodes,
        request.Weight,
        DateTime.UtcNow,
        NutritionalInformation.From(request),
        NutritionalInformation.FromTotalWeight(request));
    
    public static Product From(Guid id, UpdateProductRequest request) => new(
        id,
        request.Name,
        request.Barcodes,
        request.Weight,
        DateTime.UtcNow,
        NutritionalInformation.From(request),
        NutritionalInformation.FromTotalWeight(request));

    public Guid Id { get; }
    public string Name { get; }
    public List<string> Barcodes { get; }
    public int Weight { get; }
    public DateTime LastUpdated { get; }
    public NutritionalInformation PerHundredGrams { get; }
    public NutritionalInformation PerPacket { get; }
}