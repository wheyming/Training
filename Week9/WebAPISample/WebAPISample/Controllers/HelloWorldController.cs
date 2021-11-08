using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using WebAPISample.Filters;

namespace WebAPISample.Controllers
{
    [Log] // LogAttribute
    [LogAction] // LogActionAttribute
    [RoutePrefix("api/Hello")]
    public class HelloWorldController : ApiController
    {
        // GET: HelloWorld
        [Route("")]
        public IEnumerable<string> Get()
        {
            IList<string> list = new List<string>();
            list.Add("This is my first");
            list.Add("API call");
            return list;
        }

        [Route("Find/{id:range(50, 100)}")]
        public string Get(int id)
        {
            return "Parameterized Get method with parameter ID: " + id;
        }

        [Route("FindOpt/{name:Length(3, 5)?}")]
        public string Get(string name = "ram")
        {
            return "Parameterized Get method with parameter Name: " + name;
        }

        [Route("{id:int}/{name}")]
        public string Get(int id, string name)
        {
            return "Parameterized Get method with parameters ID: " + id + " Name: " + name;
        }

        [Route("~/v1")]
        public string Get(string id, string name)
        {
            return "Default route Get method with parameters ID: " + id + " Name: " + name;
        }

        [Route("")]
        public void Post(string id)
        {
        }

        [Route("Find1")]
        public string Post(int id)
        {
            return "I am inside Post(Find1) Int: " + id;
        }

        [Route("Find1")]
        public string Post1([FromBody] int id)
        {
            return "I am inside Post(Find1) Int: " + id;
        }

        [Route("Find")]
        public Student Post()
        {
            return new Student() { ID = 1, Name = "WM" };
        }

        //[Route("Store")]
        //public Student Post(Student stu)
        //{
        //    return stu;
        //}

        [Route("Store1")]
        public Dictionary<int, Student> Post(Student stu, int ID)
        {
            Dictionary<int, Student> dict = new Dictionary<int, Student>();
            dict.Add(ID, stu);
            return dict;
        }

        [Route("Store2")]
        public Student Post([FromUri] Student stu)
        {
            return stu;
        }

        [Route("")]
        public HttpResponseMessage Post(int id, int id1)
        {
            HttpResponseMessage message = new HttpResponseMessage();
            if (id == id1)
            {
                message.StatusCode = System.Net.HttpStatusCode.OK;
            }
            else
                message.StatusCode = System.Net.HttpStatusCode.BadRequest;

            message.ReasonPhrase = "You are calling the post with two int args";
            return message;
        }

        [Route("")]
        public IHttpActionResult Post(int id, int id1, int id2)
        {
            if (id == 100)
            {
                return NotFound();
            }
            else
                return Ok();
        }

        List<Student> students = new List<Student>();

        public HelloWorldController()
        {
            students.Add(new Student(1, "H"));
            students.Add(new Student(2, "P"));
            students.Add(new Student(3, "E"));
            students.Add(new Student() { ID = 4, Name = "S" });
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

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Student()
        {

        }
        public Student(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }
    }
}