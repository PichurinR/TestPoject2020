using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Dashboard
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDaleted { get; set; }
        public IEnumerable<Section> Sections { get; set; }
    }
}
