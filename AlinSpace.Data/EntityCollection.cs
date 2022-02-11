using System.Collections;

namespace AlinSpace.Data
{
    public class EntityCollection : ICollection<Entity>
    {
        private readonly IDictionary<object, Entity> entities = new Dictionary<object, Entity>();

        public int Count => entities.Count;

        public bool IsReadOnly => false;

        public void Add(Entity item)
        {
            entities.TryAdd(item.Key, item);
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Entity item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Entity[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Entity> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(Entity item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
