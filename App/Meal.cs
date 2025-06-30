namespace App
{
    /// <summary>
    /// Какая-то food. Inherits Product
    /// <list type="bullet">
    /// <item>Guid Id</item>
    /// <item>string Name</item>
    /// <item>DateTime DateManufactured</item>
    /// <item>decimal Price</item>
    /// <item>int StorageLifetime</item>
    /// <item>enum : byte Type</item>
    /// </list>
    /// </summary>
    public class Meal : Product, IMyCloneable<Meal>, ICloneable
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
        object ICloneable.Clone()
        {
            return Clone();
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
