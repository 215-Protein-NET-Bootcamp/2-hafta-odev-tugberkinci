using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaHomework2.Service.IServices
{
    public interface IGenericService<T>  where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T Add(string name);
        T Update(string name);
        T Delete(string name);
    }
}
