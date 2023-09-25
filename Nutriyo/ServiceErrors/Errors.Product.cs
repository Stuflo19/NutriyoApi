using ErrorOr;

namespace Nutriyo.ServiceErrors;


public static class Errors
{
    public static class Product
    {
        public static Error NotFound => Error.NotFound("Product.NotFound", "Product Not Found");
    }
}