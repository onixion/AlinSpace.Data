namespace AlinSpace.Data
{
    public interface IMerger
    {
        Entity Merge(Entity entityA, Entity entityB);
    }
}
