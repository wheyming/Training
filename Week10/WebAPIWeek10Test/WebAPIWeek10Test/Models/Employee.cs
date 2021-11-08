using System;

namespace WebAPIWeek10Test.Models
{
    public class Employee
    {
        public string Name { get; private set; }
        public Guid ID { get; private set; }
        public string Position { get; private set; }

        public Employee(string name, Guid id, string position)
        {
            Name = name;
            ID = id;
            Position = position;
        }
    }
}