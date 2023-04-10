using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagment.Application.Contracts.Presistance;
using LeaveManagment.Application.DTOs.LeaveAllocationDTO;
using LeaveManagment.Application.Features.LeaveAllocation.Request.Queries;
using MediatR;

namespace LeaveManagment.Application.Features.LeaveAllocation.Handler.Queries
{
    public class GetLeaveAllocationRequestWithDetailsHandler : IRequestHandler<GetLeaveAllocationRequestWithDetails, LeaveAllocationDTO>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        public GetLeaveAllocationRequestWithDetailsHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }

        public async Task<LeaveAllocationDTO> Handle(GetLeaveAllocationRequestWithDetails request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.GetLeaveAllocationWithDetailsById(request.Id);
            if (leaveAllocation == null)
            {
                throw new Exception("Something Went Wrong !!");

            }

            return _mapper.Map<LeaveAllocationDTO>(leaveAllocation);
        }
    }
}
