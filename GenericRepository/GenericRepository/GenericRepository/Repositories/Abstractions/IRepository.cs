using GenericRepository.Contexts;
using GenericRepository.Entites;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Repositories.Abstractions;

public interface ITRepository<T> where T : BaseEntity, new()
{
    IQueryable<T> GetAllT(bool isTracking, params string[] includes);
}

public class TRepository<T> : ITRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContext _context;
    public TRepository(AppDbContext context)
    {
        _context = context;
        
    }
public IQueryable<T> GetAllT(bool isTracking, params string[] includes)
{
    var query = _context.Set<T>().AsQueryable();
    if (!isTracking)
    {
        query = query.AsNoTracking();
    }
    if (includes.Length > 0)
    {
        foreach (string include in includes)
        {
            query = query.Include(include);

        }
    }
    return query;
}
}

