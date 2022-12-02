using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ModelsLayer;

namespace RepoLayer
{
    public interface IRepositoryClass
    {
        Employee PostEmployee(Employee e);
    }

    public class RepositoryClass : IRepositoryClass
    {


        private readonly IMyLogger _logger;

        public RepositoryClass(IMyLogger logger)
        {
            _logger = logger;
        }
        public Employee PostEmployee(Employee e)
        {
            //Employee e = new Employee();
            // e.EmailAddress = "jkskfjl@company.com";

            if (File.Exists("EmployeeList.json"))
            {
                string oldList = File.ReadAllText("EmployeeList.json");
                List<Employee> empList = JsonSerializer.Deserialize<List<Employee>>(oldList)!;

                empList.Add(e);

                string empObjectsToJString = JsonSerializer.Serialize(empList);
                File.WriteAllText("EmployeeList.json", empObjectsToJString);//write the json string to the file 
                _logger.LogStuff(e);
                return e;

                

            }
            else
            {
                List<Employee> empList = new List<Employee>();
                empList.Add(e);

                string EmpObjectsToJString = JsonSerializer.Serialize(empList);
                File.WriteAllText("EmployeeList.json", EmpObjectsToJString);//write the json string to the file 
                _logger.LogStuff(e);
                return e;

            }
        }
    }
}