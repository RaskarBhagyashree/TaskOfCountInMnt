using System.Data;
using Microsoft.Data.SqlClient;
using TaskOfCreateApi.Interfaces;
using TaskOfCreateApi.Models;

namespace TaskOfCreateApi.Repositories
{
    public class UserRepository : IUserRepositoryInterface
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<IEnumerable<CountsOfUserProjectCustomerTask>> GetUserProjectCustomerTasks()
        {
            var result = new List<CountsOfUserProjectCustomerTask>();

            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("GetCountsOfUserProjectCustomerTask", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    await connection.OpenAsync();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var userProjectCustomerTaskCounts = new CountsOfUserProjectCustomerTask
                            {
                                UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                                NoOfCustomers = reader.GetInt32(reader.GetOrdinal("NoOfCustomers")),
                                NoOfProjects = reader.GetInt32(reader.GetOrdinal("NoOfProjects")),
                                NoOfTasks = reader.GetInt32(reader.GetOrdinal("NoOfTasks"))
                            };
                            result.Add(userProjectCustomerTaskCounts);
                        }
                    }
                }
            }

            return result;
        }
    }
}
