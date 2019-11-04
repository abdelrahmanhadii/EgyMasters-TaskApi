using DTOs;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ServiceContracts
{
    public interface IClientService:IService<CreateClientDTO, UpdateClientDTO>
    {
        IEnumerable<ListClientDTO> GetAll();
    }
}
