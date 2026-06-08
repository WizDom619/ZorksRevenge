using System;
using System.Collections.Generic;
using System.Text;

namespace ZorksRevenge
{
    internal class PlayerData
    {
        private bool isPlaying = true;
        private Room _currentRoom;

        public PlayerData()
        {

        }


        public void SetPlayerRoom(Room currentroom)
        {
            _currentRoom = currentroom;
        }

        public bool IsPlaying
        {
            get { return isPlaying; }
        }
        public Room CurrentRoom
        {
            get { return _currentRoom; }
        }
    }
}
