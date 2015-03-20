using PoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolApp.Repositories
{
    interface IServiceRepo
    {
        Service GetById(int id);
        void Add(Service service);
        void Edit(Service service);
        void Delete(int id);
        void Clear();
        int GetCount();
        List<Service> GetAllServices();
    }
}