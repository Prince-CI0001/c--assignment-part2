using System.Text.RegularExpressions;

namespace Csharp.Assignment2
{
    public class LinearEquation
    {
        public string SolveEquation(string eq)
        {
            double result;

            var split = eq.Split('=');
            var leftNums = getNums(split[0]);
            var leftVals = condense(leftNums);

            var rightNums = getNums(split[1]);
            var rightVals = condense(rightNums);

            leftVals[0] -= rightVals[0];
            rightVals[1] -= leftVals[1];

            if (leftVals[0] == 0)
            {
                if (rightVals[1] == 0)
                {
                    return "Infinite solutions";
                }
                return "No solution";
            }

            result = (double)rightVals[1] / leftVals[0];

            return $"x={result:0.##}";
        }

        private List<string> getNums(string str)
        {
            var result = new List<string>();
            var re = new Regex("[-+\b]?(\\d*)x?");
            foreach (Match match in re.Matches(str))
            {
                if (match.Value.Length == 0)
                {
                    continue;
                }
                result.Add(match.Value);
            }
            return result;
        }

        private int[] condense(List<string> nums)
        {
            int[] result = new int[2];
            foreach (var num in nums)
            {
                if (num.Contains("x"))
                {
                    string cleanedNum = num.Replace("x", "").Replace("+", "");
                    if (cleanedNum.Length == 0 || cleanedNum.Equals("-"))
                    {
                        cleanedNum += "1";
                    }
                    result[0] += int.Parse(cleanedNum);
                }
                else
                {
                    result[1] += int.Parse(num.Replace("+", ""));
                }
            }
            return result;
        }
    }
}
