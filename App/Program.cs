namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var entityOrigin = new Entity(Guid.NewGuid());
            var entityCopy = entityOrigin.Clone();

            var product = new Product(DateTime.Now, 10);
            var productCopy = product.Clone();

            var meal = new Meal(product.DateManufactured, product.Price, 10, MealType.Main);
            var mealCopy = meal.Clone();
        }
    }
}
