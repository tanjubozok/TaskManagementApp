using System.Linq.Expressions;
using TaskManagementApp.Domain.Entities;

namespace TaskManagementApp.Application.Interfaces;

public interface IUserRepository
{
    Task<AppUser?> GetByFilterAsync(Expression<Func<AppUser, bool>> filter, bool asNoTracking = true);
}
