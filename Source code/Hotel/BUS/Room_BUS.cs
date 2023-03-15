using DAL;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class Room_BUS
    {
        private readonly Room_DAL dalRoom = new Room_DAL();

        public DataTable GetRoom()
        {
            return dalRoom.GetRoom();
        }

        public List<Room_DTO> LoadRoomList()
        {
            return dalRoom.LoadRoomList();
        }

        public List<Room_DTO> GetRoomList(string roomName)
        {
            return dalRoom.GetRoomList(roomName);
        }

        public DataTable GetRoomPrice(string roomName)
        {
            return dalRoom.GetRoomPrice(roomName);
        }

        public DataSet LoadRoomType()
        {
            return dalRoom.LoadRoomType();
        }

        public DataTable LoadRoomName(string type)
        {
            return dalRoom.LoadRoomName(type);
        }

        public bool CheckRoomName(string roomName)
        {
            return dalRoom.CheckRoomName(roomName);
        }

        public void UpdateRoomBusy(string roomName)
        {
            dalRoom.UpdateRoomBusy(roomName);
        }

        public void UpdateRoomFree(string roomName)
        {
            dalRoom.UpdateRoomFree(roomName);
        }

        public void AddRoom(Room_DTO room)
        {
            dalRoom.AddRoom(room);
        }

        public void EditRoom(Room_DTO room)
        {
            dalRoom.EditRoom(room);
        }

        public void DeleteRoom(string roomName)
        {
            dalRoom.DeleteRoom(roomName);
        }

        public DataTable SearchRoom(string searchText)
        {
            return dalRoom.SearchRoom(searchText);
        }
    }
}
