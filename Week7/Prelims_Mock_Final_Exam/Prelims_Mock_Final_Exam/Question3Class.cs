using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelims_Mock_Final_Exam
{
    class NoInputException : Exception
    {
        public NoInputException()
        {

        }
    }

    class Question3Class
    {            
        string postString;
        string[] strArr;
        Dictionary<char, int> charDictionary;
        List<string> strArrAfter;
        string strTemp;

        public string removeDuplicate(string input1)
        {
            strArrAfter = new List<string>();
            charDictionary = new Dictionary<char, int>();
            // strArr = new string[input1.Split(' ').Length];
            strArr = input1.Split(' ');
            foreach(string eachStrInArr in strArr)
            {
                strTemp = "";
                charDictionary.Clear();
                foreach(char charInString in eachStrInArr)
                {
                    if(!charDictionary.ContainsKey(charInString))
                    {
                        charDictionary.Add(charInString, 1);
                        strTemp += charInString;
                    }
                    else
                    {
                        continue;
                    }
                }       
                strArrAfter.Add(strTemp);
            }
            foreach (string eachStrInStrTemp in strArrAfter)
            {
                if (eachStrInStrTemp == strArrAfter[0])
                {
                    postString += eachStrInStrTemp;
                }
                else
                {
                    postString += " " + eachStrInStrTemp;
                }
            }
            return postString;
        }
    }
}
