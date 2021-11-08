using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6FridayDemonstrationPM
{
    public class Employee
    {
        [JsonProperty] // Required in order to internal set. Will not work without Json Property. 
        public string Name { get; internal set; }
        [JsonProperty]
        public Guid Id { get; internal set; }
        [JsonProperty]
        public string Designation { get; internal set; }
        [JsonProperty]
        public string Address { get; internal set; } 
        public double Salary { get; set; } // If publc access modifier, JsonProperty not required.

        public Employee()
        { }
    }
}
