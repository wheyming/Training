using SelfHostedWebAPIConsoleApp.Filters;
using SelfHostedWebAPIConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostedWebAPIConsoleApp.Controller
{
    [Log]
    [RoutePrefix("Api/Hello")]
    class StudentController : ApiController
    {
        List<Student> students = new List<Student>();
        public StudentController()
        {
            students.Add(new Student() { ID = 1, Name = "A" });
            students.Add(new Student() { ID = 2, Name = "B" });
            students.Add(new Student() { ID = 3, Name = "C" });
            students.Add(new Student() { ID = 4, Name = "D" });
        }

        [HttpGet]
        [Route("GetAllFormatters")]
        public IEnumerable<string> GetAllFormatters(int ID)
        {
            IList<string> formattersList = new List<string>();
            foreach (var item in GlobalConfiguration.Configuration.Formatters)
                formattersList.Add(item.ToString());
            return formattersList;
        }

        [HttpGet]
        [Route("")]
        public Student GetStudent(int ID)
        {
            Student student = students.Where(x => x.ID == ID).FirstOrDefault();
            return student;
        }


        [Route("UpdateName")]
        public List<Student> Patch(Student student)
        {
            Student existingstudent = students.Where(x => x.ID == student.ID).FirstOrDefault();
            if (existingstudent == null)
                return null;
            students.Remove(existingstudent);

            students.Add(student);
            return students;
        }

        [Route("PutStudent")]
        public List<Student> Put(Student student)
        {
            Student existingstudent = students.Where(x => x.ID == student.ID).FirstOrDefault();
            if (existingstudent != null)
            {
                students.Remove(existingstudent);
            }
            students.Add(student);
            return students;
        }

        [Route("DeleteById/{id}")]
        public List<Student> Delete(int ID)
        {
            Student existingstudent = students.Where(x => x.ID == ID).FirstOrDefault();
            if (existingstudent != null)
            {
                students.Remove(existingstudent);
            }
            return students;
        }

        [Route("Delete")]
        public List<Student> Delete(Student student)
        {
            Student existingstudent = students.Where(x => x.ID == student.ID).FirstOrDefault();
            if (existingstudent != null)
            {
                students.Remove(existingstudent);
            }
            return students;
        }

    }
}
