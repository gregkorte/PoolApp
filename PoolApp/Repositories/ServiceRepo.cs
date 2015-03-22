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

        public ServiceRepo(string connection = "PoolAppContext")
        {
            _dbContext = new PoolAppContext(connection);
        }

        public Service GetById(int id)
        {
            return _dbContext.Services.Where(s => s.ID == id).First<Service>();
        }

        public void Add(Service service)
        {
            _dbContext.Services.Add(service);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var services = _dbContext.Services.Where(s => s.ID == id);
            _dbContext.Services.RemoveRange(services);
            _dbContext.SaveChanges();
        }

        public void Edit(Service service)
        {
            var q = _dbContext.Services.Where(c => c.ID == service.ID);
            foreach (Service dbService in q)
            {
                dbService.Name = service.Name;
                dbService.Cost = service.Cost;
                dbService.WorkUnit = service.WorkUnit;
            }

            _dbContext.SaveChanges();
        }

        public List<Service> GetAllServices()
        {
            return _dbContext.Services.ToList();
        }

        public List<Service> GetAllByUserId(string userID)
        {
            return _dbContext.Services.Where(s => s.UserID == userID).ToList();
        }

        public void Clear()
        {
            var services = this.GetAllServices();
            _dbContext.Services.RemoveRange(services);
            _dbContext.SaveChanges();
        }

        public int GetCount()
        {
            return _dbContext.Services.Count<Service>();
        }
    }
}