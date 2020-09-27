using challenge.Models;
using System;
using System.Threading.Tasks;

namespace challenge.Repositories
{
    public interface IEmployeeRepository
    {
        Employee GetById(String id);
        Employee GetById(String id, bool includeDirectReports);
        Employee Add(Employee employee);
        Compensation Add(Compensation compensation);
        Compensation GetCompensationByEmployeeId(String id);
        Employee Remove(Employee employee);
        Task SaveAsync();
    }
}