namespace Assignment2
{
    class NicoCipher
    {   
        private char[,] matrix(string message, int rows,int cols)
        {
            char[,] vs = new char[rows, cols];
            int iterator = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (iterator < message.Length)
                    {   
                       // if(message[iterator] == '\0')
                        vs[i, j] = message[iterator++];
                    }

          
                }
            }
            return vs;
        }
        public string Cipher(string message,string key)
        {
            //Giving sorted values to the key
             char[] key_char = key.ToCharArray();

             for(int i = 0; i < key_char.Length; i++)
              {
                int min = Int32.MaxValue;
                int index = -1;
                for(int j = 0; j < key_char.Length; j++) 
                {
                        if(Char.IsDigit(key_char[j]))
                        continue;

                        else if( (int)key_char[j] < min ) 
                        {
                        min = (int)key_char[j];
                        index = j;
                }
            }
                if (index > -1)
                {
                    key_char[index] = (i+1).ToString()[0];
                }
        }

            // rows to be filled in matrix
            int rows = (int)Math.Ceiling(Convert.ToDecimal(message.Length) / Convert.ToDecimal(key.Length));
            
            char[,] vs = matrix(message, rows, key.Length);


            //created dcitionary for sorting the matrix columns

            SortedDictionary<char, char[]> map = new SortedDictionary<char, char[]>();
            for (int i = 0; i < key.Length; i++)
            {
                char[] arr = new char[rows];
                for (int j = 0; j < rows; j++)
                {
                    arr[j] = vs[j, i];
                }
                map.Add(key_char[i], arr);
            }
            string newStr = "";
            foreach (var item in map)
            {
                for(int i=0;i<item.Value.Length;i++)
                {
                    if (item.Value[i] == '\0')
                        newStr += ' ';
                    else
                    {
                        newStr += item.Value[i];
                    }
                }
            }
            //resultig matrix formation
            char[,] resultingMatrix = matrix(newStr, map.Count, rows);

            newStr = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < map.Count; j++)
                {

                    newStr += resultingMatrix[j, i];
                }
            }
            return newStr;
        }    
    }
}
