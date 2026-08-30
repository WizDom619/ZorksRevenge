using System;
using System.Collections.Generic;
using System.Text;
using ZorksRevenge.Save;

namespace ZorksRevenge.CommandEvents
{
    internal class SaveEvent : CommandEvent
    {
        public override void Process()
        {
            GameSaveMemento GSM = new GameSaveMemento();

            GSM.PlayerData.Name = Player.Name;
            GSM.PlayerData.CurrentRoomID = Player.CurrentRoomID;
            GSM.PlayerData.MoveCount = Player.MoveCount;
            GSM.PlayerData.DidBeatGame = Player.DidBeatGame;
            GSM.PlayerData.Inventory = Player.Inventory;

            GSM.Rooms = GameData.Rooms;
            GSM.Items = GameData.Items;
            GSM.Containers = GameData.Containers;
            GSM.NPCS = GameData.NPCS;

            SaveManager.Save(GSM);
        }

        public override void Display()
        {
            ZorkPrinter.Print("Game Saved\n");
        }
    }
}
