using System.Collections.Generic;

namespace BAL.ViewModel
{
    public class DashboardVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<SectionVM> Sections { get; set; }
    }
}
