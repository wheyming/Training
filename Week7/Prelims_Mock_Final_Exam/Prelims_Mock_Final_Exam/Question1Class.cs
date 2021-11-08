using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prelims_Mock_Final_Exam
{
    class Question1Class
    {
        Dictionary<int, int> multiplyDict = new Dictionary<int, int>();
        public int calculateLCM(int input1, int input2)
        {
            int multiplyInput1;
            int multiplyInput2;
            int LCM;

            for(int i = 1; ;i++)
            {
                multiplyInput1 = (input1 * i);
                multiplyInput2 = (input2 * i);
                multiplyDict.Add(multiplyInput1, multiplyInput2);
                if(multiplyDict.ContainsKey(multiplyInput2))
                {
                    LCM = multiplyInput2;
                    break;
                }
                else if (multiplyDict.ContainsValue(multiplyInput1))
                {
                    LCM = multiplyInput1;
                    break;
                }
            }
            return LCM;
        }

        public int calculateHCF(int input1, int input2, int LCM)
        {
            int HCF = (input1 * input2) / LCM;
            return HCF;
        }

    }
}
