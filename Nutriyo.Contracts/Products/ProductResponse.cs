namespace Nutriyo.Contracts.Products;

public record ProductResponse(
    Guid Id,
    string Name,
    List<string> Barcodes,
    string ImageLocation,
    DateTime LastUpdated,
    NutritionalInformation PerHundredGrams,
    NutritionalInformation PerServing,
    NutritionalInformation PerPacket
);