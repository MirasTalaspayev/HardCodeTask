using HardCodeTask.Application.DTOs;
using HardCodeTask.Application.IServices;
using HardCodeTask.Infrastructure.Data;

namespace HardCodeTask.Application.Services;
public abstract class BaseService<T> : IBaseService<T> where T : BaseDTO<int>
{
    private readonly AppDbContext _db;
    public BaseService(AppDbContext db)
    {
        _db = db;
    }
    public bool Add(T dto)
    {
        throw new NotImplementedException();
    }

    public ICollection<T> GetAll()
    {
        throw new NotImplementedException();
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }
}
