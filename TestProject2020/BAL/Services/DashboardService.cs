using AutoMapper;
using BAL.Interface;
using BAL.ViewModel;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BAL.Services
{
    public class DashboardService : IDashboardService
    {
        private AppDBContext _dbContext;
        private IMapper _mapper;
        public DashboardService(AppDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public long CreateDashboard(DashboardVM model)
        {
            var dashboard = _mapper.Map<Dashboard>(model);

            _dbContext.Dashboards.Add(dashboard);
            _dbContext.SaveChanges();

            return dashboard.Id;
        }

        public void DeleteDashboard(long id)
        {
            var dashboard = _dbContext.Dashboards.SingleOrDefault(d => d.Id == id && !d.IsDaleted);
            if (dashboard != null)
            {
                dashboard.IsDaleted = true;
            }

            _dbContext.SaveChanges();
        }

        public DashboardVM GetDashboard(long id)
        {
            return _mapper.Map<DashboardVM>(_dbContext.Dashboards.SingleOrDefault(d => d.Id == id && !d.IsDaleted));
        }

        public IEnumerable<DashboardVM> GetDashboards()
        {
            return _mapper.Map<IEnumerable<DashboardVM>>(_dbContext.Dashboards.Where(d => !d.IsDaleted));
        }
    }
}
