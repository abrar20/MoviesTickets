using Microsoft.EntityFrameworkCore;
using MoviesTickets.Data.Base;
using MoviesTickets.Models;

namespace MoviesTickets.Data.Services
{
    public class CinemasService:EntityBaseRepository<Cinema>,ICinemasService
    {
        private readonly AppDbContext _context;

        public CinemasService(AppDbContext context) : base(context)
        { }
    }
}
