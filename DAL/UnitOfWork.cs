using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.IRepositories;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private IClientRepository clientRepo;
        private ICallRepository callRepo;
        private readonly TaskDbContext _context;
        public UnitOfWork(TaskDbContext context)
        {
            this._context = context;
        }
        public ICallRepository CallRepo
        {
            get
            {
                if (callRepo == null)
                {
                    callRepo = new CallRepository(_context);
                }
                return callRepo;
            }
        }
        public IClientRepository ClientRepo
        {
            get
            {
                if (clientRepo == null)
                {
                    clientRepo = new ClientRepository(_context);
                }
                return clientRepo;
            }
        }
        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
