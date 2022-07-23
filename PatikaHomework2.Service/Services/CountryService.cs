
using PatikaHomework2.Data.Model;
using PatikaHomework2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaHomework2.Service.Services
{
    public class CountryService : ICountryService
    {
        public async Task<Country> Add(string name)
        {
            throw new NotImplementedException();
        }

        public async Task< Country> Delete(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<Country> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Country> Update(string name)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Country>> IGenericService<Country>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
