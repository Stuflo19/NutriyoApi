namespace Nutriyo.Contracts.Products;

public record ProductResponse(
    Guid Id,
    string Name,
    List<string> Barcodes,
    int Weight,
    DateTime LastUpdated,
    NutritionalInformation PerHundredGrams,
    NutritionalInformation Total
);