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
        Service Add(Service service);
        Service Edit(Service service);
        Service Delete(int id);
        List<Service> GetAllServices(int id);
        void Clear();
        int GetCount();
    }
}