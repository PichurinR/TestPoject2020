using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class Ticket
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public int Vote { get; set; }
        public long SectionId { get; set; }
    }
}
