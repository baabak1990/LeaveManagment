using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagment.Application.Contracts.Presistance;
using LeaveManagment.Application.DTOs.LeaveTypeDTO;
using LeaveManagment.Application.Features.LeaveType.Request.Commands;
using MediatR;

namespace LeaveManagment.Application.Features.LeaveType.Handler.Commands
{
    public class CreateLeaveTypeCommandHandler:IRequestHandler<CreateLeaveTypeCommand, int>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public CreateLeaveTypeCommandHandler(IMapper mapper, ILeaveTypeRepository leaveTypeRepository)
        {
            _mapper = mapper;
            _leaveTypeRepository = leaveTypeRepository;
        }
        public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
        {
            var leaveType = _mapper.Map<Domin.Entity.Model.LeaveType>(request.LeaveTypeDto);
            await _leaveTypeRepository.Add(leaveType);
            return leaveType.Id;
        }
    }
}
