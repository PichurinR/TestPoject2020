using BAL.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL.Interface
{
    public interface ITicketService
    {
        long CreateTicket(TicketVM model);
        void Voting(long id);
        long EditTicket(TicketVM model);
    }
}
