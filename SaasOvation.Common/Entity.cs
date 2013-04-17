namespace SaasOvation.Common
{
    public abstract class Entity<TId,TValue> where TId : Id<TValue>
    {
        protected Entity(TId id)
        {
            Id = id;
        }
        
        public TId Id { get; private set; }

    }
}