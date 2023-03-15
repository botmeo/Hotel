using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class RoomType_BUS
    {
        private readonly RoomType_DAL dalRoomType = new RoomType_DAL();

        public DataTable GetRoomType()
        {
            return dalRoomType.GetRoomType();
        }

        public bool CheckRoomType(string type)
        {
            return dalRoomType.CheckRoomType(type);
        }

        public void AddRoomType(RoomType_DTO roomType)
        {
            dalRoomType.AddRoomType(roomType);
        }

        public void EditRoomType(RoomType_DTO roomType)
        {
            dalRoomType.EditRoomType(roomType);
        }

        public void DeleteRoomType(string roomType)
        {
            dalRoomType.DeleteRoomType(roomType);
        }

        public DataTable SearchRoomType(string searchText)
        {
            return dalRoomType.SearchRoomType(searchText);
        }
    }
}
