using projector_ecs_new.Core.Repositories;
using projector_ecs_new.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projector_ecs_new.Data.Repositories
{
    public class RequestRepository : IRequestRepository
    {
    
        private readonly DataContext _context;
        public RequestRepository(DataContext context)
        {
            _context = context;
        }
        public List<Request> getAllRequests()
        {
            return _context.Requests.ToList();  
        }
    }
}
