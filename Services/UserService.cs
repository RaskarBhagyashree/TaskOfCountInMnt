using System.Data;
using Microsoft.Data.SqlClient;
using TaskOfCreateApi.Interfaces;
using TaskOfCreateApi.Models;
using TaskOfCreateApi.Repositories;

public class UserService : IUserServiceInterface
{
   
    private readonly IUserRepositoryInterface _userRepository;

    public UserService(IUserRepositoryInterface userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<IEnumerable<CountsOfUserProjectCustomerTask>> GetUserProjectCustomerTaskCountsAsync()
    {
        return await _userRepository.GetUserProjectCustomerTasks();
    }
}

