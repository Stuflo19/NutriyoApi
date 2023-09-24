namespace Nutriyo.Contracts.Products;

public record NutritionalInformation(int Calories,
    int Fat,
    int OfWhichSaturates,
    int Carbohydrate,
    int OfWhichSugars,
    int Protein,
    int Salt);