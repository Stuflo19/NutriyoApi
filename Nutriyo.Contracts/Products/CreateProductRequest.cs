namespace Nutriyo.Contracts.Products;

public record CreateProductRequest(
    string Name,
    List<string> Barcodes,
    NutritionalInformation PerHundredGrams,
    NutritionalInformation PerServing,
    NutritionalInformation PerPacket);