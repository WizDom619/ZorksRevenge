using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge
{
    class TestRandomTemp
    {
        // Create All Rooms 
        // And add Items to the Rooms. 
        /*_rooms = new List<Room>
        {
            .AddItem(new Item("Cake", ""))
            .AddNPC(new NPC("Bob")
                .AddInstructions("Play my Game for a prize")
                .AddWant("Rock")
                .AddWant("Skull")
                .AddMiniGame(new FinalBoss())
                .AddPrize(new Item("Gold", "shiney and yellow"))
                )
            .AddContainer(new Container("Box")
                .AddItem(new Item("Fork", "stabby"))),


            new Room("Hallway", "You are in a long hallway")

            new Room("Bedroom", "A room where you sleep")
        }; 

        // Set all paths between Rooms. 
        ConnectPaths(FindRoom("Entry"), Direction.North, FindRoom("Hallway"));
        ConnectPaths(FindRoom("Hallway"), Direction.East, FindRoom("Bedroom"));

        return _rooms;*/



        //_rooms 


        private static void ConnectExits(Room room1, Direction dir, Room room2)
        {
            room1.Exits[dir] = room2.ID;

            if (dir == Direction.North) { room2.Exits[Direction.South] = room1.ID; }
            else if (dir == Direction.South) { room2.Exits[Direction.North] = room1.ID; }
            else if (dir == Direction.East) { room2.Exits[Direction.West] = room1.ID; }
            else { room2.Exits[Direction.East] = room1.ID; }
        }
    }
}
