using DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceContracts
{
    public interface ICallService : IService<CreateCallDTO, UpdateCallDTO>
    {
    }
}
