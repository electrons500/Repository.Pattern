using Webapi.In.Repository.Pattern.Models;
using Webapi.In.Repository.Pattern.Models.Data.EmployeeDBContext;

namespace Webapi.In.Repository.Pattern.Infrastructure
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int id);
        bool AddEmployee(AddEmployeeModel model);  
        bool UpdateEmployee(Employee employee);
        bool DeleteEmployee(int id);
        void Save();
    }
}
