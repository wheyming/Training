using System.Collections.Generic;
using System.Web.Http;

namespace WebAPISample.Controllers
{
    [RoutePrefix("api/Hello1")]
    public class HelloWorldWithAttributeController : ApiController
    {
        [Route("")]
        [HttpGet]
        public IEnumerable<string> FindValues()
        {
            IList<string> list = new List<string>();
            list.Add("This is my first");
            list.Add("API call from Hello World Attribute");
            return list;
        }

        [HttpGet]
        public string FindValuesWithParam(int id)
        {
            return "I am calling this from parameterized Get method from HellowController With Attribute with parameter: " + id;
        }

    }
}
