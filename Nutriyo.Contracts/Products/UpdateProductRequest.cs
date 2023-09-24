namespace Nutriyo.Contracts.Products;

public record UpdateProductRequest(
    Guid Id,
    string Name,
    List<string> Barcodes,
    string ImageLocation,
    NutritionalInformation PerHundredGrams,
    NutritionalInformation PerServing,
    NutritionalInformation PerPacket);