using System.Web.Http;

namespace WebAPIWeek10Test.Controllers
{
    [RoutePrefix("Calculator")]
    public class Week10TestQuestion1Controller : ApiController
    {
        [HttpGet]
        [Route("Addition")]
        public int Addition(int numberOne, int numberTwo)
        {
            return (numberOne + numberTwo);
        }
        [HttpGet]
        [Route("Subtraction")]
        public int Subtraction(int numberOne, int numberTwo)
        {
            return (numberOne - numberTwo);
        }
        [HttpGet]
        [Route("Multiplication")]
        public int Multiplication(int numberOne, int numberTwo)
        {
            return (numberOne * numberTwo);
        }
        [HttpGet]
        [Route("Division")]
        public int Division(int numberOne, int numberTwo)
        {
            return (numberOne / numberTwo);
        }
        [HttpGet]
        [Route("Remainder")]
        public int Remainder(int numberOne, int numberTwo)
        {
            return (numberOne % numberTwo);
        }
    }
}
