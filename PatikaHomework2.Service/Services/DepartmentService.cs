using Dapper;
using PatikaHomework2.Data.Context;
using PatikaHomework2.Data.Model;
using PatikaHomework2.Service.IServices;

namespace PatikaHomework2.Service.Services
{
    public class DepartmentService : IDepartmentService
    {

        private readonly DapperContext dapperDbContext;

        public DepartmentService(DapperContext dapperDbContext) : base()
        {
            this.dapperDbContext = dapperDbContext;
        }

        public async Task<IEnumerable<Department>> GetAll()
        {

            var sql = "SELECT * FROM department";
            using (var connection = dapperDbContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QueryAsync<Department>(sql);
                return result;
            }
            
        }

        public async Task<Department> GetById(int id)
        {
            var query = "SELECT * FROM department WHERE Id = @Id";
            using (var connection = dapperDbContext.CreateConnection())
            {
                connection.Open();
                var result = await connection.QueryFirstAsync<Department>(query, new { id });
                return result;
            }
        }

        public async Task<Department> Add(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Department> Delete(int id)
        {
            throw new NotImplementedException();
        }

     
        public async Task<Department> Update(string name)
        {
            throw new NotImplementedException();
        }

      
    }
}
