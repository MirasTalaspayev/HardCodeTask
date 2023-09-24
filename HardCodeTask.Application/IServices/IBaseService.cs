using HardCodeTask.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardCodeTask.Application.IServices;
public interface IBaseService<T> where T : BaseDTO<int>
{
    public ICollection<T> GetAll();
    public T GetById(int id);
    public bool Add(T dto);
}
