using HotelManagementSystem.Models;
using HotelManagementSystem.Repositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Services
{
    class RoomService
    {
        private readonly RoomRepository _roomRepository;
       
        public RoomService(RoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }

        

        public List<Room> GetAllRooms() => _roomRepository.GetAllRooms();

        public void AddRoom(Room room) => _roomRepository.AddRoom(room);

        public void UpdateRoom(Room room) => _roomRepository.UpdateRoom(room);

        public void DeleteRoom(int roomId) => _roomRepository.DeleteRoom(roomId);
    }
}

