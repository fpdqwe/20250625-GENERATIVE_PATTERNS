namespace App
{
    /// <summary>
    /// Base entity class
    /// <list type="bullet">
    /// <item>Guid Id</item>
    /// <item>string Name</item>
    /// </list>
    /// </summary>
    public class Entity : IMyCloneable<Entity>, ICloneable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Entity(Guid id, string? name = null)
        {
            Id = id;
            if (name != null)
                Name = name;
            else
                Name = $"Entity #{id}";
        }
        protected Entity(Entity origin) : this(origin.Id, origin.Name) { }
        public Entity Clone()
        {
            return new Entity(this);
        }
        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
