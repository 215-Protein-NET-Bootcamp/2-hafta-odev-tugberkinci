using PatikaHomework2.Data.Context;
using PatikaHomework2.Dto.Dto;
using PatikaHomework2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaHomework2.Service.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly PgContext _pgContext;

        public DepartmentService(PgContext pgContext)
        {
            _pgContext = pgContext;
        }


        public Department Add(string name)
        {
            throw new NotImplementedException();
        }

        public Department Delete(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {

            return _pgContext.department.ToList();
                throw new NotImplementedException();
        }

        public Department GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Department Update(string name)
        {
            throw new NotImplementedException();
        }
    }
}
