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
    public class EditleaveRequestCommandHandler : IRequestHandler<EditleaveRequestCommand, Unit>
    {
        private readonly IleaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public EditleaveRequestCommandHandler(IleaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(EditleaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.GetAsync(request.Id);
            if (request.EditleaveRequestDto != null)
            {
                _mapper.Map(request.EditleaveRequestDto, leaveRequest);
                await _leaveRequestRepository.Update(leaveRequest);

            }
            else if (request.EditLeaveRequestApproval != null)
            {
                await _leaveRequestRepository.ChangeApproval(leaveRequest, request.EditLeaveRequestApproval.Approved);
            }
            return Unit.Value;
        }
    }
}
