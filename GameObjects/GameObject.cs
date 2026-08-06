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
            if (ID == "I001") { Colour = ConsoleColor.Yellow; }
            if (ID == "I002") { Colour = ConsoleColor.Blue; }
            if (ID == "I003") { Colour = ConsoleColor.Green; }
            if (ID == "I004") { Colour = ConsoleColor.Cyan; }
            if (ID == "I005") { Colour = ConsoleColor.Red; }
            if (ID == "I006") { Colour = ConsoleColor.Magenta; }
            if (ID == "I007") { Colour = ConsoleColor.White; }

            if (ID == "I033") { Colour = ConsoleColor.DarkGreen; }
            if (ID == "I034") { Colour = ConsoleColor.DarkRed; }
            if (ID == "I035") { Colour = ConsoleColor.DarkBlue; }
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
