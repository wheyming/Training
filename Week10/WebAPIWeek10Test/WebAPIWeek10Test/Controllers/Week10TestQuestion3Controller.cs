using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Http;
using WebAPIWeek10Test.Models;

namespace WebAPIWeek10Test.Controllers
{
    [RoutePrefix("EmployeeDetails")]
    public class Week10TestQuestion3Controller : ApiController
    {
        List<Employee> EmployeeList;

        public Week10TestQuestion3Controller()
        {
            if (!File.Exists("EmployeeList"))
            {
                File.Create("EmployeeList");
            }
            EmployeeList = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText("EmployeeList"));
        }

        [HttpPost]
        [Route("AddEmployee")]
        public void AddEmployee(string name, string position)
        {
            Employee employeeObj = new Employee(name, Guid.NewGuid(), position);
            EmployeeList?.Add(employeeObj);
            File.WriteAllText("EmployeeList", JsonConvert.SerializeObject(EmployeeList));
        }

        [HttpPatch]
        [Route("UpdateEmployeeName")]
        public void UpdateEmployeeName(string name, Guid guid)
        {
            Employee employee = EmployeeList.Where(x => x.ID == guid).FirstOrDefault();
            if (employee != null)
            {
                string position = employee.Position;
                EmployeeList.Remove(employee);
                EmployeeList.Add(new Employee(name, guid, position));
                File.WriteAllText("EmployeeList", JsonConvert.SerializeObject(EmployeeList));
            }
        }

        [HttpPatch]
        [Route("UpdateEmployeePosition")]
        public void UpdateEmployeePosition(string position, Guid guid)
        {
            Employee employee = EmployeeList.Where(x => x.ID == guid).FirstOrDefault();
            if (employee != null)
            {
                string name = employee.Name;
                EmployeeList.Remove(employee);
                EmployeeList.Add(new Employee(name, guid, position));
                File.WriteAllText("EmployeeList", JsonConvert.SerializeObject(EmployeeList));
            }
        }

        [HttpDelete]
        [Route("DeleteEmployee")]
        public void DeleteEmployee(Guid guid)
        {
            Employee employee = EmployeeList.Where(x => x.ID == guid).FirstOrDefault();
            if (employee != null)
            {
                EmployeeList.Remove(employee);
            }
            File.WriteAllText("EmployeeList", JsonConvert.SerializeObject(EmployeeList));
        }

        [HttpGet]
        [Route("GetEmployeeDetails")]
        public Employee GetEmployeeDetails(Guid guid)
        {
            Employee employee = EmployeeList.Where(x => x.ID == guid).FirstOrDefault();
            if (employee != null)
            {
                return employee;
            }
            else
            {
                return null;
            }
        }
        [HttpGet]
        [Route("GetAllEmployeeDetails")]
        public List<Employee> GetAllEmployeeDetails()
        {
            return EmployeeList;
        }
    }
}
