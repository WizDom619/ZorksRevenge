using System;
using System.Collections.Generic;

namespace ZorksRevenge
{
    internal class Room
    {
        public string name {  get; private set; }
        private string description;
        private bool is_player_here;

        private Room northern_room;
        private Room southern_room;
        private Room eastern_room;
        private Room western_room;

        private List<Item> items;

        //public event EventHandler<RoomAddItemEventArgs> on_item_added;

        public Room(string name, string description)
        {
            this.name = name;
            this.description = description;
            is_player_here = false;

            items = new List<Item>();
        }

        public void Add_Item(Item item)
        {
            items.Add(item);
        } 
        public void Set_Connected_Room(Room room, CompasDirection.Direction dir)
        {
            switch (dir)
            {
                case CompasDirection.Direction.North:
                    northern_room = room;
                    break;

                case CompasDirection.Direction.South:
                    southern_room = room;
                    break;

                case CompasDirection.Direction.East:
                    eastern_room = room;
                    break;

                case CompasDirection.Direction.West:
                    western_room = room;
                    break;
            }
        }
        public string To_String()
        {
            string result = "";

            result += $"{name}: {description}\n";
            foreach (Item item in items)
            {
                result += $"\t{item.To_String()} \n";
            }
            if (northern_room != null) { result += $"\n\tNorth of me is {northern_room.name}"; }
            if (southern_room != null) { result += $"\n\tSouth of me is {southern_room.name}"; }
            if (eastern_room != null) { result += $"\n\tEast of me is {eastern_room.name}"; }
            if (western_room != null) { result += $"\n\tWest of me is {western_room.name}"; }

            result += $"\n ";

            return result;
        }
        public bool Is_Player_Here
        {
            get { return is_player_here; }
            set { is_player_here = value; }
        }
    }
}
