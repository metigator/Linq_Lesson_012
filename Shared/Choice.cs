namespace Shared
{
    public class Choice
    {
        public int Order { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            if(ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if(obj.GetType() != this.GetType()) return false;

            var other = (Choice)obj;
            return Order == other.Order && Description.Equals(other.Description);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            //check null
            hash = hash * 23 + Order.GetHashCode();
            hash = hash * 23 + Description.GetHashCode(); 
            return hash;
        }
    }
}
