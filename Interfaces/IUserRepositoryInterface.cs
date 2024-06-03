using TaskOfCreateApi.Models;

namespace TaskOfCreateApi.Interfaces
{
    public interface IUserRepositoryInterface
    {
        Task<IEnumerable<CountsOfUserProjectCustomerTask>> GetUserProjectCustomerTasks();
    }
}
