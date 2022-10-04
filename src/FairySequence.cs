namespace Assignment2
{
    public class FairySequence
    {
        public void Fairy(int n)
        {   
            Dictionary<string, double> map = new();
            map.Add("0/1", 0);
            map.Add("1/1", 1);
            for(int i=1; i < n; i++)
            {
                for(int j=n;j>i;j--)
                {
                    double value = (double)i / j;
                        if(map.ContainsValue(value))
                            continue;
                        else
                        {
                            map.Add(i+"/"+j, value);
                        }
                    
                }
            }
            foreach (KeyValuePair<string, double> author in map.OrderBy(key => key.Value))
            {
                Console.WriteLine( author.Key);
            }
        }
    }
}
