using static AbstractFactory.Implementation;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
            var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
            shoppingCartForBelgium.CalculateCosts();

            var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
            var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
            shoppingCartForFrance.CalculateCosts();

            Console.ReadKey();
        }
    }
}