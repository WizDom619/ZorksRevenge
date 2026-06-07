using System;
using System.Collections.Generic;
using static ZorksRevenge.Room;

namespace ZorksRevenge
{
    // Access anything relevant to rooms is managed here. 
    // Room data is in a separate class. 
    // Rooms are instantiated in another class and returned, keeps things cleaner. 
    internal class RoomManager
    {
        private List<Room> rooms;

        public RoomManager()
        {
            rooms = new RoomData().InstantiateRoomData();
        }
        public Room Find_Room(string name)
        {
            Room return_room = new Room("Unkown Room", "Unknown Desc");

            foreach (Room room in rooms)
            {
                if (room.name == name)
                {
                    return_room = room;
                }
            }
            return return_room;
        }        
        public string To_String()
        {
            string result = ""; 

            foreach(Room room in rooms)
            {
                result += room.To_String();
            }

            return result;
        }        
    }
}
