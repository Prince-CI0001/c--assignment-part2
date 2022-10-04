namespace Csharp.Assignment2
{
     public class PilishStrings
    {
        public string Pilist(string str)
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
