
using System.Text.Json;

namespace ModelsLayer;
public class Employee
{
    public string Name {get; set;}
    public string EmailAddress { get; set;}
    public string Password { get; set;}
    public string Type { get; set; }
   // public  int ID { get; set;}


    public Employee (string name, string email, string password, string type){
        Name = name;
        EmailAddress = email;
        Password = password;
        Type = type;
    }
    public override string ToString() {
        return $"Email Address: {EmailAddress}\nPassword: {Password}";
    }

    
}