using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment2
{
    class Pilish_Strings
    {
        public string PublishString(string str)
        {
            int[] piStream = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 8, 9, 7, 9 }; 
            string newStr = "";
            int counter = 0;
            while (str.Length > 0 && counter < piStream.Length)
            {
                if (str.Length >= piStream[counter])
                {
                    newStr += str.Substring(0, piStream[counter])+" ";
                    str = str.Substring(piStream[counter], str.Length - piStream[counter]);
                }
                else
                {
                    str = str.PadRight(piStream[counter], str[str.Length - 1]);
                    newStr += str; 
                }
                counter++;
            }
           return newStr;
        }
    }
}
