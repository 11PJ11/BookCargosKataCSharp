namespace BookCargos.Model
{
    public class CubicFeet
    {
        private readonly int _value;

        public CubicFeet(int value)
        {
            _value = value;
        }

        protected bool Equals(CubicFeet other)
        {
            return _value == other._value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CubicFeet) obj);
        }

        public override int GetHashCode()
        {
            return _value;
        }
    }
}