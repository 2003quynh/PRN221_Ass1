using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Repositories
{
    class RoomRepository : IRoomRepository
    {
        private readonly PRN221_HotelManagementSystemContext _context;
        private readonly List<Room> _rooms = new(); // Giả sử đang sử dụng danh sách để lưu trữ tạm thời.

        public RoomRepository(PRN221_HotelManagementSystemContext context)
        {
            _context = context;
            
        }

       

        public List<Room> GetAllRooms()
        {
            return _context.Rooms.ToList(); 
        }

        public void AddRoom(Room room)
        {
            
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void UpdateRoom(Room room)
        {
            var existingRoom = _rooms.FirstOrDefault(r => r.RoomId == room.RoomId);
            if (existingRoom != null)
            {
                existingRoom.RoomNumber = room.RoomNumber;
                existingRoom.RoomType = room.RoomType;
                existingRoom.Status = room.Status;
                existingRoom.Price = room.Price;
            }
        }

        public void DeleteRoom(int roomId)
        {
            var roomToDelete = _rooms.FirstOrDefault(r => r.RoomId == roomId);
            if (roomToDelete != null)
            {
                _rooms.Remove(roomToDelete);
            }
        }
    }
}

