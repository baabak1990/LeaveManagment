using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagment.Application.Contracts.Presistance;
using LeaveManagment.Application.DTOs.LeaveRequestDTO;
using LeaveManagment.Application.Features.LeaveRequest.Request.Queries;
using MediatR;

namespace LeaveManagment.Application.Features.LeaveRequest.Handler.Queries
{
    public class ListOfLeaveRequestHandler : IRequestHandler<ListOfLeaveRequest, List<LeaveRequestDTO>>
    {
        private readonly IleaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public ListOfLeaveRequestHandler(IMapper mapper, IleaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }
        public async Task<List<LeaveRequestDTO>> Handle(ListOfLeaveRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _leaveRequestRepository.GetAllAsync();
            return _mapper.Map<List<LeaveRequestDTO>>(leaveRequests);
        }
    }
}
