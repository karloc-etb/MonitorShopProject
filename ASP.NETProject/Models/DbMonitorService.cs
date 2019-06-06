using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETProject.Models
{
    public class DbMonitorService : IMonitorRepository
    {
        private readonly AppDbContext _appDbContext;

        public DbMonitorService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Monitor> GetAllMonitors()
        {
            return _appDbContext.Monitors;
        }

        public Monitor GetMonitorById(int id)
        {
            return _appDbContext.Monitors.FirstOrDefault(m => m.Id == id);
        }
    }
}
