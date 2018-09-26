using FriendOrganizer.Models;
using FriendOrganizer.Ui.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace FriendOrganizer.Ui.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private Friend _selectedFriend;
        private IFriendDataService _dataService;       

        public MainViewModel(IFriendDataService dataService)
        {
            Friends = new ObservableCollection<Friend>();
            _dataService = dataService;
        }
        public async Task LoadAsync()
        {
            var friends = await _dataService.GetAllAsync();
            Friends.Clear();
            foreach(var friend in friends)
            {
                Friends.Add(friend);
            }
        }
        public ObservableCollection<Friend> Friends { get; set; }

        public Friend SelectedFriend
        {
            get { return _selectedFriend; }
            set
            {
                _selectedFriend = value;
                OnPropertyChanged();
            }
        }
    }
}
