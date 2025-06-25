namespace App
{
    public interface IMyCloneable<out T>
    {
        public T Clone();
    }
}
