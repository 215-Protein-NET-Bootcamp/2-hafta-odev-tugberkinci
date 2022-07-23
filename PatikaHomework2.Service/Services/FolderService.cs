
using PatikaHomework2.Data.Model;
using PatikaHomework2.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaHomework2.Service.Services
{
    public class FolderService : IFolderService
    {
        public async Task<Folder> Add(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Folder> Delete(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<Folder> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Folder> Update(string name)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Folder>> IGenericService<Folder>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
