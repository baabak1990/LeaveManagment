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
    public class GetListOfLeaveAllocationWithDetailsRequestHandler:IRequestHandler<GetListOfLeaveAllocationWithDetailsRequest,List<ListOfLeaveAllocationWithDetails>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
        public GetListOfLeaveAllocationWithDetailsRequestHandler(IMapper mapper, ILeaveAllocationRepository leaveAllocationRepository)
        {
            _mapper = mapper;
            _leaveAllocationRepository = leaveAllocationRepository;
        }
        public async Task<List<ListOfLeaveAllocationWithDetails>> Handle(GetListOfLeaveAllocationWithDetailsRequest request, CancellationToken cancellationToken)
        {
            //we want to use include by EFCORE
            var leaveAllocations = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails();
            return _mapper.Map<List<ListOfLeaveAllocationWithDetails>>(leaveAllocations);
        }
    }
}
