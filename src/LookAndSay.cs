namespace Csharp.Assignment2
{
    class LookAndSay
    {
        public string[] LookSay(int start , int length)
        {
            string str;
            int count;
            string[] strings = new string[length];
            strings[0] = Convert.ToString(start);
            string s = Convert.ToString(start);
            for (int i = 1; i < length; i++)
            {
                count = 0;
                str = "";
                char prev = '\0';
                for (int j = 0; j < s.Length; j++)
                {
                    if (prev == '\0')
                    {
                        prev = s[j];
                    }
                    else if (s[j - 1] != s[j])
                    {
                        str += count;
                        str += prev;
                        count = 0;
                        prev = s[j];
                    }
                    count++;
                }
                str += count;
                str += prev;
                s = str;
                strings[i] = str;
            }
            return strings;
        }
    }
}
