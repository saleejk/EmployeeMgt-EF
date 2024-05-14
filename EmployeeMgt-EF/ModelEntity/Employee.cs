using System.ComponentModel.DataAnnotations;

namespace EmployeeMgt_EF.ModelEntity
{
    public class Employee
    {
        [Key]
        public int E_id {  get; set; }
        public string E_name {  get; set; }
        public int E_salary {  get; set; }
        public string E_role {  get; set; }
    }
}
