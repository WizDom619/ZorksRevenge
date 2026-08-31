using System.Text.Json;
using ZorksRevenge.GameObjects;
using ZorksRevenge.Test;
using ZorksRevenge.Utility;


namespace ZorksRevenge.FileIO
{
    public static class FileManager
    {
        private static readonly string _saveDir = "SavedGame";
        private static readonly string _newGameDir = "NewGame";

        private static readonly Dictionary<DataDir, string> _Path = new Dictionary<DataDir, string>()
        {
            [DataDir.Player] = "PlayerSaveFile",
            [DataDir.Rooms] = "RoomSaveFile",
            [DataDir.Items] = "ItemSaveFile",
            [DataDir.Containers] = "ContainerSaveFile",
            [DataDir.NPCS] = "NPCSaveFile"
        };         

        //private static GameSaveMemento _mem = new GameSaveMemento();
         
        public static void Initialize()
        {
            Directory.CreateDirectory(_saveDir);
        }
        
        public static void Save(GameSaveMemento mem)
        {
            string path;

            path = SlotPath("PlayerSaveFile");
            var json1 = JsonSerializer.Serialize(mem.PlayerData, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json1);

            path = SlotPath("RoomSaveFile");
            var json2 = JsonSerializer.Serialize(mem.Rooms, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json2);

            path = SlotPath("ItemSaveFile");
            var json3 = JsonSerializer.Serialize(mem.Items, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json3);

            path = SlotPath("ContainerSaveFile");
            var json4 = JsonSerializer.Serialize(mem.Containers, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json4);

            path = SlotPath("NPCSaveFile");
            var json5 = JsonSerializer.Serialize(mem.NPCS, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json5);
        }

        public static void LoadGameData()
        {
            var contents = new Dictionary<DataDir, string>();

            foreach (KeyValuePair<DataDir, string> kvp in _Path)
            {
                string path = Path.Combine(_saveDir, $"{kvp.Value}.json");

                if (!File.Exists(path))
                {
                    ZorkPrinter.PrintLine($"Did not find {kvp.Key} {kvp.Value}");
                }

                contents[kvp.Key] = File.ReadAllText(path);
            }

            GameSaveMemento GSM = new GameSaveMemento
            {
                PlayerData = JsonSerializer.Deserialize<PlayerData>(contents[DataDir.Player]),
                Rooms = JsonSerializer.Deserialize<List<Room>>(contents[DataDir.Rooms]),
                Items = JsonSerializer.Deserialize<List<Item>>(contents[DataDir.Items]),
                Containers = JsonSerializer.Deserialize<List<Container>>(contents[DataDir.Containers]),
                NPCS = JsonSerializer.Deserialize<List<NPC>>(contents[DataDir.NPCS])
            };

            Player.Name = GSM.PlayerData.Name;
            Player.CurrentRoomID = GSM.PlayerData.CurrentRoomID;
            Player.MoveCount = GSM.PlayerData.MoveCount;
            Player.DidBeatGame = GSM.PlayerData.DidBeatGame;
            Player.Inventory = GSM.PlayerData.Inventory;

            GameData.Rooms = GSM.Rooms;
            GameData.Items = GSM.Items;
            GameData.Containers = GSM.Containers;
            GameData.NPCS = GSM.NPCS;
        }

        public static void NewGameData()
        {
            var contents = new Dictionary<DataDir, string>();

            foreach (KeyValuePair<DataDir, string> kvp in _Path)
            {
                string path = Path.Combine(_newGameDir, $"{kvp.Value}.json");

                if (!File.Exists(path))
                {
                    ZorkPrinter.PrintLine($"Did not find {kvp.Key} {kvp.Value}");
                    Console.ReadLine();
                }

                contents[kvp.Key] = File.ReadAllText(path);
            }

            GameSaveMemento GSM = new GameSaveMemento
            {
                PlayerData = JsonSerializer.Deserialize<PlayerData>(contents[DataDir.Player]),
                Rooms = JsonSerializer.Deserialize<List<Room>>(contents[DataDir.Rooms]), 
                Items = JsonSerializer.Deserialize<List<Item>>(contents[DataDir.Items]), 
                Containers = JsonSerializer.Deserialize<List<Container>>(contents[DataDir.Containers]), 
                NPCS = JsonSerializer.Deserialize<List<NPC>>(contents[DataDir.NPCS]) 
            };

            Player.CurrentRoomID = GSM.PlayerData.CurrentRoomID;
            Player.MoveCount = GSM.PlayerData.MoveCount;
            Player.DidBeatGame = GSM.PlayerData.DidBeatGame;
            Player.Inventory = GSM.PlayerData.Inventory;

            GameData.Rooms = GSM.Rooms;
            GameData.Items = GSM.Items;
            GameData.Containers = GSM.Containers;
            GameData.NPCS = GSM.NPCS;
        }

        public static GameSaveMemento? FreshLoad()
        {
            string path = SlotPath("FreshLoad");
            if (!File.Exists(path))
            {
                return null;
            }

            var json = File.ReadAllText(path);

            return JsonSerializer.Deserialize<GameSaveMemento>(json);
        }

        public static void Delete(string slotName)
        { 
            File.Delete(SlotPath(slotName)); 
        }

        public static IEnumerable<string> ListSlots()
        {
            return Directory.GetFiles(_saveDir, "*.json").Select(Path.GetFileNameWithoutExtension)!;
        }

        private static string SlotPath(string slotName)
        {
            return Path.Combine(_saveDir, $"{slotName}.json");
        }
    }
}
