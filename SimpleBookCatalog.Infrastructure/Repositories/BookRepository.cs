using Microsoft.EntityFrameworkCore;
using SimpleBookCatalog.Application.Interfaces;
using SimpleBookCatalog.Infrastructure.Context;
namespace SimpleBookCatalog.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly SimpleBookCatalogDbContext _context;
        public BookRepository(IDbContextFactory<SimpleBookCatalogDbContext>factory)
        {
            _context = factory.CreateDbContext();
        }
    }
}
