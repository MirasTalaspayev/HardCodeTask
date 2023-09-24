using AutoMapper;
using HardCodeTask.Application.DTOs;
using HardCodeTask.Application.IServices;
using HardCodeTask.Domain.Entities;
using HardCodeTask.Infrastructure.Data;

namespace HardCodeTask.Application.Services;
public abstract class BaseService<T, TEntity> : IBaseService<T> 
    where T : BaseDTO<int> 
    where TEntity : BaseEntity<int>
{
    private readonly AppDbContext _db;
    private readonly IMapper _mapper;
    public BaseService(AppDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
    public bool Add(T dto)
    {
        var newEntity = _mapper.Map<TEntity>(dto);
        var result =  _db.Set<TEntity>().Add(newEntity);
        if (result == null) 
        {
            return false;
        }

        _db.SaveChanges();
        return true;
    }

    public ICollection<T> GetAll()
    {
        var data = _db.Set<TEntity>().ToList();

        return _mapper.Map<List<T>>(data);
    }

    public T GetById(int id)
    {
        var result = _db.Set<TEntity>().Select(x => _mapper.Map<T>(x)).FirstOrDefault(x => x.Id == id);
        
        return result;
    }
}
