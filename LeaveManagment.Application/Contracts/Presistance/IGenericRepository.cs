﻿namespace LeaveManagment.Application.Contracts.Presistance;

public interface IGenericRepository<T> where T:class
{
    Task<T> GetAsync(int id);
    Task<IReadOnlyList<T>> GetAllAsync();
    Task<T> Add(T entity);
    Task<T> Update(T entity);
    Task<T> Delete(T entity);
}