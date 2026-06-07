using System;
using static ZorksRevenge.CompasDirection;
using static ZorksRevenge.Room;

namespace ZorksRevenge
{
    /* I;ve struggled with finding a way to have the managers to reference each other without being tightly coupled. 
     * The Wiring Manager is the soultion. 
     * This class is the only class tightly coupled with the other managers. 
     * It's job is to connect references such as what items are in what rooms. 
     * ... What rooms connect to each other. 
     * ... What manager subscribe to other managers events. ect...
     */
    internal class WiringManager
    {
        private ItemManager item_manager;
        private RoomManager room_manager;

        public WiringManager(GameData game_data) 
        {
            item_manager = game_data.item_manager;
            room_manager = game_data.room_manager;

            // Put the objects locations
            Put_All_Items_In_All_Rooms();
            // Set which rooms know about each other. 
            Connect_All_Rooms();
        }
        //Could remove the slipt of the two methods and just have the one. 
        private void Put_All_Items_In_All_Rooms()
        {
            Put_Item_In_Room("Rock", "Entry");
            Put_Item_In_Room("Skull", "Entry");
            Put_Item_In_Room("Pile of Dust", "Hallway");
            Put_Item_In_Room("Ruby", "Bedroom");
            Put_Item_In_Room("Pen", "Bedroom");
        }
        // Not mergeed with Put_All_Items_In_All_Rooms()
        // This allows for easy parameter safety checks. 
        private void Put_Item_In_Room(string item_name, string room_name)
        {
            if (room_manager.Find_Room(room_name).name == "Unknown Room")
            {
                Console.WriteLine($"ERROR: Invalid Room Name {room_name}");
                return;
            }
            else if (item_manager.Find_Item(item_name).Name == "Unknown Item")
            {
                Console.WriteLine($"ERROR: Invalid Item Name {item_name}");
                return;
            }

            // Assign an item to sit inside a room. 
            room_manager.Find_Room(room_name).Add_Item(item_manager.Find_Item(item_name));
        }
        private void Connect_All_Rooms()
        {
            Connect_Room("Entry", new CompasDirection(Direction.North), "Hallway");
            Connect_Room("Hallway", new CompasDirection(Direction.East), "Bedroom");
        }
        private void Connect_Room(string room1, CompasDirection dir, string room2) 
        {
            if (room_manager.Find_Room(room1).name == "Unknown Room")
            {
                Console.WriteLine($"ERROR: Invalid Room Name {room1}");
                return;
            }
            else if (room_manager.Find_Room(room2).name == "Unknown Item")
            {
                Console.WriteLine($"ERROR: Invalid Item Name {room2}");
                return;
            }

            room_manager.Find_Room(room1).Set_Connected_Room(room_manager.Find_Room(room2), dir.direction);
            room_manager.Find_Room(room2).Set_Connected_Room(room_manager.Find_Room(room1), dir.Opposite());            
        }
    }
}
