using LeaveManagment.Domin.Entity.Model;

namespace LeaveManagment.Application.Contracts.Presistance;

public interface ILeaveAllocationRepository:IGenericRepository<LeaveAllocation>
{
    Task<IReadOnlyList<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    Task<LeaveAllocation> GetLeaveAllocationWithDetailsById(int id);
}