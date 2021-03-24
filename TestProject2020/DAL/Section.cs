using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Section
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long DashboardId { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; }
    }
}
