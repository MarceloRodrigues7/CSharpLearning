using static FactoryMethod.Implementation;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factories = new List<DiscountFactory> {
            new CodeDiscountFactory(Guid.NewGuid()),
            new CountryDiscountFactory("BR") };

            foreach (var factory in factories)
            {
                var discountService = factory.CreateDiscountService();
                Console.WriteLine($"Percentage {discountService.DiscountPercentage} coming from {discountService}");
            }

            Console.ReadKey();
        }
    }
}