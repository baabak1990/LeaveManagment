using LeaveManagment.Domin.Entity.Model;

namespace LeaveManagment.Application.Contracts.Presistance;

public interface IleaveRequestRepository:IGenericRepository<LeaveRequest>
{
    Task ChangeApproval(LeaveRequest leaveRequest, bool? isApproved);
}