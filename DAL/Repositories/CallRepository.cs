using DAL.IRepositories;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class CallRepository: GenaricRepository<Call>, ICallRepository
    {
        public CallRepository(TaskDbContext context):base(context)
        {

        }
    }
}
