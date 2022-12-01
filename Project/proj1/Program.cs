using System.Text.Json;

namespace proj1;
class Program
{
    static void Main(string[] args)
    {
        
      var emp  = new Employee("An employee contributes labor to an organization in exchange for compensation and benefits.");
      string EmployeesJsonFileName = "Employees object conversion to JSON string.json";
      string EmpObjectsToJString = JsonSerializer.Serialize(emp);
      File.WriteAllText(EmployeesJsonFileName,EmpObjectsToJString);//write the json string to the file 
      string ReadingEmployeesJsonFile = File.ReadAllText(EmployeesJsonFileName);
      Employee empl = JsonSerializer.Deserialize<Employee>(ReadingEmployeesJsonFile)!;//json string to json object
      Console.WriteLine(empl);
     
      int userChoice = -1;
      {
      Console.WriteLine("Welcome back, please type Manager or Staff");
      userChoice = Proj1Service.ValidateUserChoice(Console.ReadLine());
      if(userChoice < 0)
      {
        Console.WriteLine("Invalid Entry");
      }
      Choices userChose = (Choices)userChoice;
      Console.WriteLine(userChose);
    }


      Console.WriteLine("Sign in with your organizational account");
      Console.WriteLine("Type your email address");
      emp.emailAddress = Console.ReadLine()!;
      Console.WriteLine("Type your password");
      emp.Password = Console.ReadLine()!;
            
      Console.WriteLine(emp.ToString());

    }
}
