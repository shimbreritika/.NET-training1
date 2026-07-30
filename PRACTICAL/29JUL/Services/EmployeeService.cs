using _29JUL.Model;

namespace _29JUL.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=101,Name="Ritika", PhoneN=4356528938, Email="ritika@gmail.com", DeptId=11},
            new Employee{Id=102,Name="Mamta",  PhoneN=9765468389, Email="mamta@gmail.com", DeptId=11},
            new Employee{Id=103,Name="Yadav",  PhoneN=3765652868, Email="yadava@gmail.com", DeptId=12},
            new Employee{Id=104 ,Name="Riya", PhoneN=876552898, Email="riya@gmail.com", DeptId=12},

        };

        public List<Employee> getEmployees()
        {
            return employees;
        }

        public Employee? getEmployee(int deptid)
        {
            return employees.FirstOrDefault(e => e.DeptId == deptid);
        }

        public Employee? getEmployeeName(string name)
        {
            return employees.FirstOrDefault(n => n.Name == name);

        }

        public Employee addEmployee(Employee employee)
        {
            employees.Add(employee);

            return employee;
        }
    }
}
