using Webapi.In.Repository.Pattern.Infrastructure;
using Webapi.In.Repository.Pattern.Models;
using Webapi.In.Repository.Pattern.Models.Data.EmployeeDBContext;

namespace Webapi.In.Repository.Pattern.Service
{
    public class EmployeeService : IEmployee
    {
        private EmployeeDbContext _EmployeeDbContext;
        public EmployeeService(EmployeeDbContext employeeDbContext)
        {
            _EmployeeDbContext = employeeDbContext;
        }
        public bool AddEmployee(AddEmployeeModel model) 
        {
            Employee employee = new()
            {
                EmployeeId = 0,
                EmployeeName = model.EmployeeName,
                City = model.City
            };

            _EmployeeDbContext.Employees.Add(employee);
            Save();

            return true;

        }

        public bool DeleteEmployee(int id)
        {
            Employee employee = _EmployeeDbContext.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            if (employee != null)
            {
                _EmployeeDbContext.Employees.Remove(employee);
                Save();
                return true;
            }
            return false;
        }

        public Employee GetEmployee(int id)
        {
            Employee employee = _EmployeeDbContext.Employees.Where(x => x.EmployeeId == id).FirstOrDefault();
            return employee;
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employeeslist = _EmployeeDbContext.Employees.ToList();
            return employeeslist;

        }

        public void Save()
        {
            _EmployeeDbContext.SaveChanges();
        }

        public bool UpdateEmployee(Employee employee)
        {
            _EmployeeDbContext.Employees.Update(employee);
            Save();
            return true;

        }
    }
}
