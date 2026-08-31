using ZorksRevenge.GameObjects;
using ZorksRevenge.Test;

namespace ZorksRevenge.SaveLoad
{
    public class GameSaveMemento
    {
        // PlayerData
        public PlayerData PlayerData { get; set; } = new PlayerData();

        // GameData
        public List<Room> Rooms { get; set; } 
        public List<Item> Items { get; set; }
        public List<Container> Containers { get; set; }
        public List<NPC> NPCS { get; set; }

        public GameSaveMemento() 
        {

        }

    }
}
