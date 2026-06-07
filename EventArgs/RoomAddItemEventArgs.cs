namespace ZorksRevenge
{
    public class RoomAddItemEventArgs : EventArgs
    {
        public string item_name;
        public string room_name;

        public RoomAddItemEventArgs(string item_name, string room_name)
        {
            this.item_name = item_name;
            this.room_name = room_name;
        }
    }
}
