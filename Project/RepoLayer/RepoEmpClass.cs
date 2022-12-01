using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ModelsLayer;

namespace RepoLayer
{
    public class RepoEmpClass
    {
        public Employee PostEmployee(Employee e)
        {
            e.EmailAddress = "jkskfjl@company.com";

           if(File.Exists("EmployeeList.json"))
           {
            string oldList = File.ReadAllText("EmployeeList.json");
            List<Employee> empList = JsonSerializer.Deserialize<List<Employee>>(oldList)!;
            
            empList.Add(e);

            string EmpObjectsToJString = JsonSerializer.Serialize(empList);
            File.WriteAllText("EmployeeList.json",EmpObjectsToJString);//write the json string to the file 
            return e;

           }
          else
          {
            List<Employee> empList = new List<Employee>();
            empList.Add(e);

            string EmpObjectsToJString = JsonSerializer.Serialize(empList);
            File.WriteAllText("EmployeeList.json",EmpObjectsToJString);//write the json string to the file 
            return e;

          }
        }
    }
}