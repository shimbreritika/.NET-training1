using _29JUL.Model;

namespace _29JUL.Services
{
    public interface IEmployeeService
    {
        List<Employee> getEmployees();

        Employee? getEmployee(int deptid);

        Employee? getEmployeeName(string name);

        Employee addEmployee(Employee employee);
        
    }

    //contoller -----Iemployee service ---- emplyee service
    //
}
