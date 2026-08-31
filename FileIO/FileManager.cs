using System.Text.Json;
using ZorksRevenge.Data;
using ZorksRevenge.GameObjects;
using ZorksRevenge.Test;
using ZorksRevenge.Utility;

namespace ZorksRevenge.FileIO
{
    /// <summary>
    /// This class manages all file input and output. 
    /// In particular, 
    ///     (1). Loading a new game from the new game directory.
    ///     (2). Saving the game in a saved game directory.
    ///     (3). Loading a saved game from the save directory.
    /// </summary>
    public static class FileManager
    {
        private static readonly string NEW_GAME_FOLDER = "../../../NewGame";
        private static readonly string SAVE_FOLDER = "../../../SavedGame";

        private static GameData _gameData; 

        private static readonly Dictionary<DataDir, string> _Path = new Dictionary<DataDir, string>()
        {
            [DataDir.Player] = "PlayerSaveFile",
            [DataDir.Rooms] = "RoomSaveFile",
            [DataDir.Items] = "ItemSaveFile",
            [DataDir.Containers] = "ContainerSaveFile",
            [DataDir.NPCS] = "NPCSaveFile"
        };         
                 
        public static void Init(GameData gameData)
        {
            _gameData = gameData;
        }

        public static void NewGameData()
        {
            try 
            {
                // Read the Files as a String
                string newGameContainer = File.ReadAllText(NEW_GAME_FOLDER + "/NewContainerSaveFile.json");
                string newGameItem = File.ReadAllText(NEW_GAME_FOLDER + "/NewItemSaveFile.json");
                string newGameNPC = File.ReadAllText(NEW_GAME_FOLDER + "/NewNPCSaveFile.json");
                string newGamePlayer = File.ReadAllText(NEW_GAME_FOLDER + "/NewPlayerSaveFile.json");
                string newGameRoom = File.ReadAllText(NEW_GAME_FOLDER + "/NewRoomSaveFile.json");

                // Deserialise into a strongly-typed object
                _gameData.Containers = JsonSerializer.Deserialize<List<Container>>(newGameContainer);
                _gameData.Items = JsonSerializer.Deserialize<List<Item>>(newGameItem);
                _gameData.Npcs = JsonSerializer.Deserialize<List<NPC>>(newGameNPC);
                _gameData.Player = JsonSerializer.Deserialize<Player>(newGamePlayer);
                _gameData.Rooms = JsonSerializer.Deserialize<List<Room>>(newGameRoom);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {NEW_GAME_FOLDER}");
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error parsing JSON: {ex.Message}");
            }

            /*var contents = new Dictionary<DataDir, string>();

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
            */
        }

        public static void SaveGameData(GameSaveMemento mem)
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
