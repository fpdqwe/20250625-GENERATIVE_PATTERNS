namespace App
{
    /// <summary>
    /// Represents products. Inherits Entity
    /// <list type="bullet">
    /// <item>Guid Id</item>
    /// <item>string Name</item>
    /// <item>DateTime DateManufactured</item>
    /// <item>decimal Price</item>
    /// </list>
    /// </summary>
    public class Product : Entity, IMyCloneable<Product>
    {
        public DateTime DateManufactured { get; set; }
        public decimal Price { get; set; }
        public Product(DateTime dateManufactured, decimal price)
            : base(Guid.NewGuid())
        {
            Price = price;
            DateManufactured = dateManufactured;
        }
        protected Product(Product origin) : this(origin.DateManufactured, origin.Price) { }
        public virtual Product Clone()
        {
            return new Product(this);
        }
    }
}
