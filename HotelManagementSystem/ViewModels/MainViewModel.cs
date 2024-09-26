using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.ViewModels
{
    class MainViewModel : ViewModel
    {
        private Navigation navigation;
        public ViewModel CurrentViewModel { get => navigation.ViewModel; }

        public MainViewModel(Navigation navigation)
        {
            this.navigation = navigation;
            navigation.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            NotifyPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
