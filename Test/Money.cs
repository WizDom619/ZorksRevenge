namespace ZorksRevenge.Test
{
    public class Money : Item
    {
        private int _value;
        /*public Money (string name, string description, int amount)
            : base(name, description)
        {            
            _value = amount;
        }*/

        public int Value { get { return _value; }  set { _value = value; } }
    }
}
