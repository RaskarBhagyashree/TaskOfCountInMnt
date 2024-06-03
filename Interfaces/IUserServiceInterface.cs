using TaskOfCreateApi.Models;

namespace TaskOfCreateApi.Interfaces
{
    public interface IUserServiceInterface
    {
        Task<IEnumerable<CountsOfUserProjectCustomerTask>> GetUserProjectCustomerTaskCountsAsync();
    }
}
