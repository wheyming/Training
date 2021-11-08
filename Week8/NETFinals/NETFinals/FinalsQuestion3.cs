using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFinals
{
    class FinalsQuestion3
    {
        public string StringToCamelCasing(string input)
        {
            string transformedString = "";
            bool isPreviousALetter = false;
            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    if (!isPreviousALetter)
                    {
                        transformedString += Convert.ToString(char.ToUpper(character));
                        isPreviousALetter = true;
                    }
                    else
                    {
                        transformedString += Convert.ToString(char.ToLower(character));
                    }
                    continue;
                }
                else
                {
                    isPreviousALetter = false;
                    transformedString += Convert.ToString(character);
                }
            }
            return transformedString;
        }

        public SortedDictionary<char, int> ShowVowelsAndConsonantsInString(string input)
        {
            SortedDictionary<char, int> Q3bDictionary = new SortedDictionary<char, int>();
            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    if (!Q3bDictionary.ContainsKey(char.ToUpper(character)))
                    {
                        Q3bDictionary.Add(char.ToUpper(character), 1);
                    }
                    else
                    {
                        Q3bDictionary[char.ToUpper(character)]++;
                    }
                }
            }
            return Q3bDictionary;
        }
    }
}
