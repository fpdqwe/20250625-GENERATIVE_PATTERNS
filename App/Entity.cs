namespace App
{
    /// <summary>
    /// Base entity class
    /// </summary>
    public class Entity : IMyCloneable<Entity>
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
    }
}
