namespace ZorksRevenge
{
    public class GameObject
    {
        protected string _id;
        protected string _locationID;
        protected string _name;
        // Used as flavour text for world building. 
        protected string _description;
        protected ConsoleColor _colour;

        public GameObject()
        {
        }

        public virtual void Print() { }

        public string ID 
        { 
            get { return _id; } 
            set { _id = value; }
        }
        public string Name 
        { 
            get { return _name; }
            set { _name = value; }
        }
        public string LocationID
        {
            get { return _locationID; }
            set { _locationID = value; }
        }
        public string Desc
        {
            get { return _description; }
            set { _description = value; }
        }
        public ConsoleColor Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }
    }
}
