using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Week6FridayDemonstrationPM
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Ming",
                Address = "23 pears avenue",
                Designation = "CEO",
                Salary = 1000000,
            };
            Employee emp1 = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = "Ming1",
                Address = "10 pears avenue",
                Designation = "CTO",
                Salary = 1000000,
            };
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp);
            employeeList.Add(emp1);
            string employeeListJson= JsonConvert.SerializeObject(employeeList);
            // File.Create("Employee.Json");
            File.WriteAllText("Employee.json", employeeListJson);
            
            // Console.ReadLine();
            List<Employee> empTemp = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText("Employee.json"));
            string employeeJson1 = JsonConvert.SerializeObject(empTemp);
            File.WriteAllText("Employee1.json", employeeJson1);
            // When appending, ensure it is not challenging the integerity of the json function.
            Console.ReadLine();
        }
    }
}
