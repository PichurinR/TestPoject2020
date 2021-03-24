using BAL.ViewModel;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface IDashboardService
    {
        long CreateDashboard(DashboardVM model);
        void DeleteDashboard(long id);
        IEnumerable<DashboardVM> GetDashboards();
        DashboardVM GetDashboard(long id);
    }
}
