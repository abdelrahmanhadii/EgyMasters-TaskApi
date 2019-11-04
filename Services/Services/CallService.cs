using AutoMapper;
using DAL;
using DAL.IRepositories;
using DTOs;
using Models;
using Services.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CallService : ICallService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CallService(IUnitOfWork callRepo, IMapper mapper)
        {
            this._unitOfWork = callRepo;
            this._mapper = mapper;
        }
        public async Task<int> Create(CreateCallDTO model)
        {
            var RetVal = _unitOfWork.CallRepo.Create(_mapper.Map<Call>(model));
            if (await _unitOfWork.Save() > 0)
            {
                return RetVal.Id;
            }
            else
            {
                return 0;
            }
        }

        public async Task<bool> SoftDelete(int Id)
        {
            var RetVal = _unitOfWork.CallRepo.GetAllID(Id);
            if (RetVal.Id > 0)
                RetVal.IsDeleted = true;
            if (await _unitOfWork.Save() > 0)
                return true;
            else
                return false;
        }

        public async Task<bool> Update(UpdateCallDTO model)
        {
            _unitOfWork.CallRepo.Update(_mapper.Map<Call>(model));

            if (await _unitOfWork.Save() > 0)
                return true;
            else
                return false;
        }
    }
}
