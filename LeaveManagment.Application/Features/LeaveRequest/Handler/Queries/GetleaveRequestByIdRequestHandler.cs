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
    public class GetleaveRequestByIdRequestHandler : IRequestHandler<GetleaveRequestByIdRequest, LeaveRequestDTO>
    {
        private readonly IleaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
        public GetleaveRequestByIdRequestHandler(IMapper mapper, IleaveRequestRepository leaveRequestRepository)
        {
            _mapper = mapper;
            _leaveRequestRepository = leaveRequestRepository;
        }
        public async Task<LeaveRequestDTO> Handle(GetleaveRequestByIdRequest request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetAsync(request.Id);
            if (leaveRequest == null)
            {
                throw new Exception("Some thing went wrong ");
            }

            return _mapper.Map<LeaveRequestDTO>(leaveRequest);
        }
    }
}
