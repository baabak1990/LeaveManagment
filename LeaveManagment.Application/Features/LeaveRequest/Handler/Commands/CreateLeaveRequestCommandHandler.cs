using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LeaveManagment.Application.Contracts.Presistance;
using LeaveManagment.Application.Features.LeaveRequest.Request.Commands;
using MediatR;

namespace LeaveManagment.Application.Features.LeaveRequest.Handler.Commands
{
    public class CreateLeaveRequestCommandHandler:IRequestHandler<CreateLeaveRequestCommand,int>
    {
        private readonly IleaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(IleaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = _mapper.Map<Domin.Entity.Model.LeaveRequest>(request.LeaveRequestDto);
            await _leaveRequestRepository.Add(leaveRequest);
            return leaveRequest.Id;
        }
    }
}
