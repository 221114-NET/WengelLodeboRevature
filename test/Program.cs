using System.Text.Json;
namespace test;

class Program
{
    
    static void Main()
    {
        PostEmployee();
    }
    static void PostEmployee()
    {
        Employee e = new Employee();
        e.EmailAddress = "jkskfjl@company.com";

        if (File.Exists("EmployeeList.json"))
        {
            string oldList = File.ReadAllText("EmployeeList.json");
            List<Employee> empList = JsonSerializer.Deserialize<List<Employee>>(oldList)!;

            empList.Add(e);

            string empObjectsToJString = JsonSerializer.Serialize(empList);
            File.WriteAllText("EmployeeList.json", empObjectsToJString);//write the json string to the file 
            //return empList;
            Console.WriteLine(empList);

        }
        else
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(e);

            string EmpObjectsToJString = JsonSerializer.Serialize(empList);
            File.WriteAllText("EmployeeList.json", EmpObjectsToJString);//write the json string to the file 
                                                                        // return e;
            Console.WriteLine(empList);


        }
   
    }

}

public class Employee
{
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string Type { get; set; }
    // public  int ID { get; set;}

    public Employee()
    {

    }


    public Employee(string name, string email, string password, string type)
    {
        Name = name;
        EmailAddress = email;
        Password = password;
        Type = type;
    }
    public override string ToString()
    {
        return $"Email Address: {EmailAddress}\nPassword: {Password}";
    }


}



