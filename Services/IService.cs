using DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IService<C, U> where C:IDTO where U : IDTO
    {
        Task<int> Create(C model);
        Task<bool> Update(U model);
        Task<bool> SoftDelete(int Id);
    }
}
