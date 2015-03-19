using PoolApp.Context;
using PoolApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PoolApp.Repositories
{
    public class ServiceRepo : IServiceRepo
    {
        private PoolAppContext _dbContext;

        public ServiceRepo(string connection = "PoolAppDBContext")
        {
            _dbContext = new PoolAppContext(connection);
        }

        public Service GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Service Add(Service service)
        {
            throw new NotImplementedException();
        }

        public Service Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Service Edit(Service service)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetAllServices(int id)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }
    }
}