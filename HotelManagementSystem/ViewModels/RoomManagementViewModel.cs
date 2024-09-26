using HotelManagementSystem.Command;
using HotelManagementSystem.Models;
using HotelManagementSystem.Repositories;
using HotelManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelManagementSystem.ViewModels
{
    class RoomManagementViewModel : ViewModel
    {
        private RoomService _roomService;
        public ObservableCollection<Room> Rooms { get; set; }

        private Room _selectedRoom;
        public Room SelectedRoom
        {
            get => _selectedRoom;
            set
            {
                _selectedRoom = value;
                NotifyPropertyChanged(nameof(SelectedRoom));
            }
        }

        public ICommand ConfirmCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand SearchCommand { get; }

        public RoomManagementViewModel(Navigation navigation, PRN221_HotelManagementSystemContext _context)
        {
            _roomService = new RoomService(new RoomRepository(_context));
            Rooms = new ObservableCollection<Room>(_roomService.GetAllRooms());
            ConfirmCommand = new RelayCommand(Confirm);
            UpdateCommand = new RelayCommand(Update);
            DeleteCommand = new RelayCommand(Delete);
            SearchCommand = new RelayCommand(Search);
        }

        private void Confirm()
        {
            if (SelectedRoom != null)
            {
                _roomService.AddRoom(SelectedRoom);
                Rooms.Add(SelectedRoom);
                SelectedRoom = new Room(); // Reset after adding
            }
        }

        private void Update()
        {
            if (SelectedRoom != null)
            {
                _roomService.UpdateRoom(SelectedRoom);
            }
        }

        private void Delete()
        {
            if (SelectedRoom != null)
            {
                _roomService.DeleteRoom(SelectedRoom.RoomId);
                Rooms.Remove(SelectedRoom);
                SelectedRoom = null; // Clear selection
            }
        }

        private void Search()
        {
            // Logic for search based on selected criteria (not implemented in detail)
        }
    }
}
