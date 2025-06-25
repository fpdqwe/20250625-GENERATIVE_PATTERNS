namespace App
{
    /// <summary>
    /// Какая-то food
    /// </summary>
    public class Meal : Product, IMyCloneable<Meal>
    {
        public int StorageLifetime { get; set; }
        public MealType Type { get; set; }
        public Meal(DateTime dateManufactured, decimal price, int lifetime, MealType type)
            : base(dateManufactured, price)
        {
            StorageLifetime = lifetime;
            Type = type;
        }
        protected Meal(Meal origin) : this(origin.DateManufactured, origin.Price, origin.StorageLifetime, origin.Type) { }
        public override Meal Clone()
        {
            return new Meal(this);
        }
    }
    public enum MealType : byte
    {
        Soup = 1,
        Main = 2,
        Drink = 3,
        Starter = 4
    }
}
