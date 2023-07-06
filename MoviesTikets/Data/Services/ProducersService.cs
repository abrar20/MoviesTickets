using MoviesTickets.Data.Base;
using MoviesTickets.Models;

namespace MoviesTickets.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>,IProducersService
    {
        public ProducersService(AppDbContext context):base(context)
        {
            
        }
    }
}
