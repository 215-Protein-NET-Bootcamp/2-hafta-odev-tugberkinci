using Microsoft.EntityFrameworkCore;
using PatikaHomework2.Data.Context;
using PatikaHomework2.Data.Model;
using PatikaHomework2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaHomework2.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EfContext _EfContext;

        public EmployeeService(EfContext EfContext)
        {
            _EfContext = EfContext;
        }

        public Task<Employee> Add(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> Update(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _EfContext.Set<Employee>().AsNoTracking().ToListAsync(); 
           
        }


    }
}
