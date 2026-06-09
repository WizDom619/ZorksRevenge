using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge.Managers.GameData
{
    internal class PlayerData
    {
        private bool isPlaying = true;
        private Room? _currentRoom;

        public PlayerData()
        {
            _currentRoom = null;
        }


        public void SetPlayerRoom(Room currentroom)
        {
            _currentRoom = currentroom;
        }

        public bool IsPlaying
        {
            get { return isPlaying; }
        }
        public Room GetCurrentRoom
        {
            get { return _currentRoom; }
        }
    }
}
