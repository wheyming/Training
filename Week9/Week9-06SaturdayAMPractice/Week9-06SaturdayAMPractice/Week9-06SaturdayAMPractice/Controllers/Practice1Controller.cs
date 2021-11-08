using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Week9_06SaturdayAMPractice.Controllers
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }

    [RoutePrefix("api/Practice1")]
    public class Practice1Controller : ApiController
    {
        List<Student> StudentList = new List<Student>();

        public Practice1Controller()
        {
            StudentList.Add(new Student(1, "A"));
            StudentList.Add(new Student(2, "B"));
            StudentList.Add(new Student(3, "C"));
        }

        [Route("PostStudent")]
        public List<Student> Post(int ID, string Name)
        {
            StudentList.Add(new Student(ID, Name));
            return StudentList;
        }

        [Route("GetStudent")]
        public Student Get(int ID)
        {
            Student stu = StudentList.Where(x => x.ID == ID).FirstOrDefault();
            return stu;
        }

        [Route("DeleteStudent")]
        public List<Student> Delete(int ID)
        {
            Student stu = StudentList.Where(x => x.ID == ID).FirstOrDefault();
            if (stu != null)
            {
                StudentList.Remove(stu);
            }
            return StudentList;
        }

        [Route("PutStudent")]
        public List<Student> Put(int ID, string Name)
        {
            Student stu = StudentList.Where(x => x.ID == ID).FirstOrDefault();
            if (stu != null)
            {
                StudentList.Remove(stu);
            }
            StudentList.Add(new Student(ID, Name));
            return StudentList;
        }

    }
}
