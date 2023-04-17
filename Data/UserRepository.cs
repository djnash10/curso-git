using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserRepository : IUserRepository
    {
        private readonly IDbConnection _dbConnection;
        public UserRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task Delete(int id)
        {
            await _dbConnection.DeleteAsync(new Users { Id = id });
        }

        public async Task<IEnumerable<Users>> GetAll()
        {
            return await _dbConnection.GetAllAsync<Users>();
        }

        public async Task<Users> GetDetails(int id)
        {
            return await _dbConnection.GetAsync<Users>(id);
        }

        public async Task Insert(Users users)
        {
            await _dbConnection.InsertAsync(users);
        }

        public async Task Update(Users users)
        {
            await _dbConnection.UpdateAsync(users);
        }
    }
}
