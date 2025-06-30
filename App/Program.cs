namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Наследования:
             * Entity - корень
             * Product : Entity
             * Meal : Product
             * Gadget : Product
             * Phone : Gadget
             * 
             * Все свойства расписаны в summary классов для удобства
             * 
             * Плюсы IMyClonable:
             *      1. Нет приведения типов
             *      2. Можно усложнить логику под нужды проекта (но не желательно)
             *      
             * Минусы IMyCloneable:
             *      1. Не является ICloneable или другими словами зачем писать одно и то же
             *      1.1 Тоже самое как придумать новый зарядный порт для телефона, когда все используют type-c
             * 
             * =====
             * 
             * Плюсы ICloneable:
             *      1. Стандарт (даже если писать библиотеку самому лучше ориентироваться на этот интерфейс)
             *      
             * Минусы ICloneable:
             *      1. Приведение типов
             */
            var entityOrigin = new Entity(Guid.NewGuid());
            var entityCopy = entityOrigin.Clone();
            entityCopy.Name = "different entity";
            if (entityOrigin.Name == entityCopy.Name || entityOrigin.Equals(entityCopy))
                throw new Exception("Same instance (not clone)");

            var product = new Product(DateTime.Now, 10);
            var productCopy = product.Clone();
            productCopy.Name = "different product";
            if (product.Name == productCopy.Name || productCopy.Equals(product))
                throw new Exception("Same instance (not clone)");

            var meal = new Meal(product.DateManufactured, product.Price, 10, MealType.Main);
            var mealCopy = meal.Clone();
            mealCopy.Type = MealType.Starter;
            if (meal.Type == mealCopy.Type || mealCopy.Equals(meal))
                throw new Exception("Same instance (not clone)");

            var gadget = new Gadget(GadgetType.Laptop, product.DateManufactured, 100000);
            var gadgetCopy = gadget.Clone();
            gadgetCopy.Price = gadget.Price * 3;
            if (gadgetCopy.Price == gadget.Price || gadgetCopy.Equals(gadget))
                throw new Exception("Same instance (not clone)");

            var phone = new Phone(product.DateManufactured, 999);
            var phoneCopy = phone.Clone();
            phoneCopy.OperatingSystem = PhoneOS.iOS;
            if (phoneCopy.OperatingSystem == phone.OperatingSystem || phoneCopy.Equals(phone))
                throw new Exception("Same instance (not clone)");
        }
    }
}
