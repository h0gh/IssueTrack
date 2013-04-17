namespace SaasOvation.Common
{
    public abstract class Id<T>
    {
        private T _value;

        protected Id(T value)
        {
            Assert.ArgumentNotNull(value, "Id value must not be null");
            _value = value;
        }

        public virtual T Value
        {
            get { return _value; }
            protected set { _value = value; }
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return Value.Equals(obj);
        }
    }
}