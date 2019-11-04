using AutoMapper;
using DAL;
using DTOs;
using Models;
using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ClientService:IClientService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ClientService(IUnitOfWork callRepo, IMapper mapper)
        {
            this._unitOfWork = callRepo;
            this._mapper = mapper;
        }
        public async Task<int> Create(CreateClientDTO model)
        {
            var RetVal = _unitOfWork.ClientRepo.Create(_mapper.Map<Client>(model));
            if (await _unitOfWork.Save() > 0)
            {
                return RetVal.Id;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<ListClientDTO> GetAll()
        {
            return _mapper.Map<IEnumerable<ListClientDTO>>(_unitOfWork.ClientRepo.GetAll());
        }

        public async Task<bool> SoftDelete(int Id)
        {
            var RetVal = _unitOfWork.ClientRepo.GetAllID(Id);
            if (RetVal.Id > 0)
                RetVal.IsDeleted = true;
            if (await _unitOfWork.Save() > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Update(UpdateClientDTO model)
        {
            _unitOfWork.ClientRepo.Update(_mapper.Map<Client>(model));

            if (await _unitOfWork.Save() > 0)
                return true;
            else
                return false;
        }
    }
}
