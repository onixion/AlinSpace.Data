using System.Collections.Generic;

namespace AlinSpace.Data
{
    public class Entity
    {
        protected IDictionary<object, Property> Properties { get; } = new Dictionary<object, Property>();

        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        public object Key { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether or not the entity has changes.
        /// </summary>
        public bool HasChanges { get; set; }

        /// <summary>
        /// Gets or sets the flag indicating whether or not the entity has been deleted.
        /// </summary>
        public bool IsDeleted { get; set; }

        public Entity Clone()
        {
            var entity = new Entity
            {
                Key = Key,
                HasChanges = HasChanges,
                IsDeleted = IsDeleted,
            };

            foreach(var key in Properties.Keys)
            {
                entity.Properties.TryAdd(key, Properties[key].Clone());
            }

            return entity;
        }
    }
}
