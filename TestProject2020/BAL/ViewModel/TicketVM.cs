using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.ViewModel
{
    public class TicketVM
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public int Vote { get; set; }
        public long SectionId { get; set; }
    }
}
