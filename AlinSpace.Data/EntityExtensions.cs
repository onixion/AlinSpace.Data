namespace AlinSpace.Data
{
    public static class EntityExtensions
    {
        public static Entity Add(this Entity entity, Property property)
        {


            entity.Add(property);



            return entity;
        }

        //public static Entity<TKeyEntity> Add<TKeyEntity, TKeyProperty, TValue>(this Entity<TKeyEntity> entity, Property<TKeyProperty, TValue> property)
        //    where TKeyEntity : struct
        //    where TKeyProperty : struct
        //{
        //    entity.Add(property);

        //    return entity;
        //}
    }
}
