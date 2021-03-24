using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using BAL.Interface;
using BAL.ViewModel;
using DAL;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace BAL.Services
{
    public class TicketService:ITicketService
    {
        private AppDBContext _dbContext;
        private IMapper _mapper;
        public TicketService(AppDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public long CreateTicket(TicketVM model)
        {
            var ticket = _mapper.Map<Ticket>(model);

            _dbContext.Tickets.Add(ticket);
            _dbContext.SaveChanges();

            return ticket.Id;
        }

        public void Voting(long id)
        {
            var ticket = _dbContext.Tickets.SingleOrDefault(t => t.Id == id);
            if (ticket != null)
            {
                ticket.Vote++;
                _dbContext.Tickets.Update(ticket);
                _dbContext.SaveChanges();
            }
        }

        public long EditTicket(TicketVM model)
        {
            var ticket = _mapper.Map<Ticket>(model);

            _dbContext.Tickets.Update(ticket);
            _dbContext.SaveChanges();

            return ticket.Id;
        }
    }
}
