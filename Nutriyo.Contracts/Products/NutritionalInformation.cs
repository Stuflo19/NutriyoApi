namespace Nutriyo.Contracts.Products;

public class NutritionalInformation
{
    private NutritionalInformation(int calories, int fat, int ofWhichSaturates, int carbohydrate, int ofWhichSugars, int protein, int salt)
    {
        Calories = calories;
        Fat = fat;
        OfWhichSaturates = ofWhichSaturates;
        Carbohydrate = carbohydrate;
        OfWhichSugars = ofWhichSugars;
        Protein = protein;
        Salt = salt;
    }

    public static NutritionalInformation From(CreateProductRequest request) => new(
        request.PerHundredGrams.Calories,
        request.PerHundredGrams.Fat,
        request.PerHundredGrams.OfWhichSaturates,
        request.PerHundredGrams.Carbohydrate,
        request.PerHundredGrams.OfWhichSugars,
        request.PerHundredGrams.Protein,
        request.PerHundredGrams.Salt
    );

    public static NutritionalInformation FromTotalWeight(CreateProductRequest request)
    {
        var multiplier = request.Weight / 100;
        
        return new(
            request.PerHundredGrams.Calories * multiplier,
            request.PerHundredGrams.Fat * multiplier,
            request.PerHundredGrams.OfWhichSaturates * multiplier,
            request.PerHundredGrams.Carbohydrate * multiplier,
            request.PerHundredGrams.OfWhichSugars * multiplier,
            request.PerHundredGrams.Protein * multiplier,
            request.PerHundredGrams.Salt * multiplier
        );
    }

    public static NutritionalInformation From(UpdateProductRequest request) => new(
        request.PerHundredGrams.Calories,
        request.PerHundredGrams.Fat,
        request.PerHundredGrams.OfWhichSaturates,
        request.PerHundredGrams.Carbohydrate,
        request.PerHundredGrams.OfWhichSugars,
        request.PerHundredGrams.Protein,
        request.PerHundredGrams.Salt
    );

    public static NutritionalInformation FromTotalWeight(UpdateProductRequest request)
    {
        var multiplier = request.Weight / 100;
        
        return new(
            request.PerHundredGrams.Calories * multiplier,
            request.PerHundredGrams.Fat * multiplier,
            request.PerHundredGrams.OfWhichSaturates * multiplier,
            request.PerHundredGrams.Carbohydrate * multiplier,
            request.PerHundredGrams.OfWhichSugars * multiplier,
            request.PerHundredGrams.Protein * multiplier,
            request.PerHundredGrams.Salt * multiplier
        );
    }

    public int Calories { get; }
    public int Fat { get; }
    public int OfWhichSaturates { get; }
    public int Carbohydrate { get; }
    public int OfWhichSugars { get; }
    public int Protein { get; }
    public int Salt { get; }
}