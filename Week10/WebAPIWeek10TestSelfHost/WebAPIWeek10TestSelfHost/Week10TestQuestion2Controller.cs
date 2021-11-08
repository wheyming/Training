using System.Collections.Generic;
using System.Web.Http;

namespace WebAPIWeek10TestSelfHost.Controllers
{
    [RoutePrefix("StringTransformer")]
    public class Week10TestQuestion2Controller : ApiController
    {
        [HttpGet]
        [Route("UpperCase")]
        public string TransformUpperCase(string input)
        {
            return input.ToUpper();
        }

        [HttpGet]
        [Route("LowerCase")]
        public string TransformLowerCase(string input)
        {
            return input.ToLower();
        }

        [HttpGet]
        [Route("CamelCase")]
        public string TransformCamelCase(string input)
        {
            string[] inputArray = input.Split(' ');
            string transformedString = "";
            transformedString += inputArray[0];
            for (int i = 1; i < inputArray.Length; i++)
            {
                transformedString += ' ';
                transformedString += char.ToUpper(inputArray[i][0]);
                for (int j = 1; j < inputArray[i].Length; j++)
                {
                    transformedString += inputArray[i][j];
                }
            }
            return transformedString;
        }

        [HttpGet]
        [Route("SplitString")]
        public List<string> SplitStringInput(string input, char inputChar)
        {
            List<string> splitList = new List<string>();
            foreach (string splitString in input.Split(inputChar))
            {
                splitList.Add(splitString);
            }
            return splitList;
        }

        [HttpGet]
        [Route("ReverseString")]
        public string ReverseString(string input)
        {
            Stack<char> charStack = new Stack<char>();
            foreach (char t in input)
            {
                charStack.Push(t);
            }
            string reversedString = "";
            for (; ; )
            {
                if (!(charStack.Count == 0))
                {
                    reversedString += charStack.Pop();
                }
                else
                {
                    break;
                }
            }
            return reversedString;
        }
    }
}
