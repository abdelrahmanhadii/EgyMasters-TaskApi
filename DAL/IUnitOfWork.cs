using DAL.IRepositories;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUnitOfWork
    {
        IClientRepository ClientRepo { get; }
        ICallRepository CallRepo { get; }
        Task<int> Save();
    }
}
