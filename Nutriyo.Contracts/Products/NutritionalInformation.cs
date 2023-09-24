namespace Nutriyo.Contracts.Products;

public abstract record NutritionalInformation(
    int Calories,
    int Fat,
    int OfWhichSaturates,
    int Carbohydrate,
    int OfWhichSugars,
    int Protein,
    int Salt
);