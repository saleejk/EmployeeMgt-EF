using EmployeeMgt_EF.ModelEntity;

namespace EmployeeMgt_EF.Service
{
    public interface IEmployee
    {

        public List<Employee> GetAllEmployee();
        public Employee GetEmployeeById(int id);
        public void AddEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public void DeleteEmployee(int id);
    }
}
