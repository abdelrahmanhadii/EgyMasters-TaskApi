using DAL.IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class ClientRepository : GenaricRepository<Client>, IClientRepository
    {
        public ClientRepository(TaskDbContext context):base(context)
        {

        }
    }
}
