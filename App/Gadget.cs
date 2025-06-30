namespace App
{
    /// <summary>
    /// Represents all gadgets type of GadgetType. Inherits Product
    /// <list type="bullet">
    /// <item>Guid Id</item>
    /// <item>string Name</item>
    /// <item>DateTime DateManufactured</item>
    /// <item>decimal Price</item>
    /// <item>enum : byte GadgetType</item>
    /// </list>
    /// </summary>
    public class Gadget : Product, IMyCloneable<Gadget>, ICloneable
    {
        public GadgetType GadgetType { get; set; }
        public Gadget(GadgetType type, DateTime dateManufactured, decimal price)
            : base(dateManufactured, price)
        {
            GadgetType = type;
        }
        protected Gadget(Gadget origin) : this(origin.GadgetType, origin.DateManufactured, origin.Price) { }
        public override Gadget Clone()
        {
            return new Gadget(this);
        }
        object ICloneable.Clone()
        {
            return Clone();
        }
    }
    public enum GadgetType : byte
    {
        PC = 0,
        Laptop = 1,
        Phone = 2,
        Tool = 3,
        Server = 4,
        Robot = 5
    }
}
