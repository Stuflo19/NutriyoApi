namespace Nutriyo.Contracts.Products;

public record UpdateProductRequest(
    Guid Id,
    string Name,
    List<string> Barcodes,
    int Weight,
    string ImageLocation,
    NutritionalInformation PerHundredGrams,
    NutritionalInformation Total);