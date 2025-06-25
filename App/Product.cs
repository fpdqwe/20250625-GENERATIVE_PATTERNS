namespace App
{
    /// <summary>
    /// Represents products
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
