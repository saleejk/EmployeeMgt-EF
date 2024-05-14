using EmployeeMgt_EF.Data;
using EmployeeMgt_EF.ModelEntity;

using Microsoft.Identity.Client;

namespace EmployeeMgt_EF.Service
{
    public class EmployeeService:IEmployee
    {
        public readonly DbContextClass dbContextClass;
        public EmployeeService(DbContextClass dbcontext) { 
        dbContextClass= dbcontext;
        }
        public List<Employee> GetAllEmployee()
        {
            var allEmployee = dbContextClass.Employees.ToList();
            return allEmployee;
        }
        public Employee GetEmployeeById(int id)
        {
            var employeeById = dbContextClass.Employees.FirstOrDefault(e => e.E_id == id);
            return employeeById;
        }
        public void AddEmployee(Employee employee)
        {
            dbContextClass.Employees.Add(employee);
            dbContextClass.SaveChanges();
        }
        public void UpdateEmployee(Employee employee)
        {
            var updateEmploy = dbContextClass.Employees.FirstOrDefault(e => e.E_id == employee.E_id);
            Employee newEmployee = new Employee { E_name = employee.E_name, E_salary = employee.E_salary, E_role = employee.E_role };
            updateEmploy.E_id = newEmployee.E_id;
            updateEmploy.E_name = employee.E_name;
            updateEmploy.E_salary= employee.E_salary;
            updateEmploy.E_role= employee.E_role;
            dbContextClass.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            var deleteEmploy = dbContextClass.Employees.FirstOrDefault(e => e.E_id == id);
            dbContextClass.Employees.Remove(deleteEmploy);
            dbContextClass.SaveChanges();
        }


    }
}
