namespace App
{
    /// <summary>
    /// Represents phones
    /// </summary>
    public class Phone : Gadget, IMyCloneable<Phone>
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
    }
    public enum PhoneOS : byte
    {
        iOS = 1,
        Android = 2
    }
}
