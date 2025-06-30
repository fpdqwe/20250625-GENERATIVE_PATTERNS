namespace App
{
    /// <summary>
    /// Represents phones. Inherits Gadget
    /// <list type="bullet">
    /// <item>Guid Id</item>
    /// <item>string Name</item>
    /// <item>DateTime DateManufactured</item>
    /// <item>decimal Price</item>
    /// <item>enum : byte GadgetType = GadgetType.Phone(const)</item>
    /// <item>string Brand (+)</item>
    /// <item>enum : byte PhoneOS (+)</item>
    /// </list>
    /// </summary>
    public class Phone : Gadget, IMyCloneable<Phone>, ICloneable
    {
        public string Brand { get; set; }
        public PhoneOS OperatingSystem { get; set; }
        public Phone(DateTime dateManufactured, decimal price, string brand = "Google", PhoneOS os = PhoneOS.Android)
            : base(GadgetType.Phone, dateManufactured, price)
        {
            Brand = brand;
            OperatingSystem = os;
        }
        protected Phone(Phone origin) : this(origin.DateManufactured, origin.Price, origin.Brand, origin.OperatingSystem) { }

        public override Phone Clone()
        {
            return new Phone(this);
        }
        object ICloneable.Clone()
        {
            return Clone();
        }
    }
    public enum PhoneOS : byte
    {
        iOS = 1,
        Android = 2
    }
}
