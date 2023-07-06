using Microsoft.EntityFrameworkCore;
using MoviesTickets.Data.Base;
using MoviesTickets.Models;

namespace MoviesTickets.Data.Services
{
    public class ActorsService :EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context):base(context)
        {}
    }
}
