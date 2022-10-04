namespace Assignment2
{
    internal class Program
    {   
        static  void PilishStrings()
        {
            PilishStrings obj = new PilishStrings();
            string str = Console.ReadLine();
            Console.WriteLine(obj.Pilist(str));
        }

        static void FairySequence()
        {
            FairySequence obj = new FairySequence();
            int n = int.Parse(Console.ReadLine());
            obj.Fairy(n);
            
        }

        static void LinearEquation()
        {
            LinearEquation obj = new LinearEquation();
            Console.WriteLine("Enter the Equation");
            string str = Console.ReadLine();
            Console.WriteLine(obj.SolveEquation(str));
        }

        static void LookAndSay()
        {
            LookAndSay obj = new LookAndSay();
            Console.WriteLine("Enter the starting Number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Length");
            int n = int.Parse(Console.ReadLine());
            string[] arr = obj.LookSay(start, n);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

        }
        static void NicoCipher()
        {
            NicoCipher obj = new NicoCipher();
            Console.WriteLine("Enter the Message");
            string msg = Console.ReadLine();
            Console.WriteLine("Enter Key");
            string key = Console.ReadLine();
            Console.WriteLine(obj.Cipher(msg, key));

        }
        static void Main()
        {
            Console.WriteLine("Enter the problem index");
            Console.WriteLine("1.Pilish Strings");
            Console.WriteLine("2.Linear Equations");
            Console.WriteLine("3. Look and say Sequence");
            Console.WriteLine("4. Fairy Sequence");
            Console.WriteLine("5. Nico Cipher");

            int index = int.Parse(Console.ReadLine());
            switch (index)
            {
                case 1:
                    PilishStrings();
                    break;
                case 2:
                    LinearEquation();
                    break;
                case 3:
                    LookAndSay();
                    break;
                case 4:
                    FairySequence();
                    break;
                case 5:
                    NicoCipher();
                    break;
                default:
                    Console.WriteLine("Sorry Wrong index");
                    break;
            }
        }
    }
}