using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaHomework2.Service.IServices
{
    public interface IGenericService<T>  where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(string name);
        Task<T> Update(string name);
        Task<T> Delete(int id);
    }
}
