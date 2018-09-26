using System.Collections.Generic;
using System.Threading.Tasks;
using FriendOrganizer.Models;

namespace FriendOrganizer.Ui.Data
{
    public interface IFriendDataService
    {
        IEnumerable<Friend> GetAll();
        Task<List<Friend>> GetAllAsync();
    }
}