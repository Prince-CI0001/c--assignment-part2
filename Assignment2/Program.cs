using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment2
{
    class Program
    {   
        public static  void PilishStrings()
        {
            Pilish_Strings obj = new Pilish_Strings();
            string str = Console.ReadLine();
            Console.WriteLine(obj.PublishString(str));
        }
        public static void FairySequence()
        {
            FairySequence obj = new FairySequence();
            int n = int.Parse(Console.ReadLine());
            obj.Fairy_Sequence(n);
            
        }
        public static void LinearEquation()
        {
            LinearEquation obj = new LinearEquation();
            Console.WriteLine("Enter the Equation");
            string str = Console.ReadLine();
            Console.WriteLine(obj.Linear_Equation(str));
        }
        public static void LookAndSay()
        {
            LookAndSay obj = new LookAndSay();
            Console.WriteLine("Enter the starting Number");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Length");
            int n = int.Parse(Console.ReadLine());
            string[] arr = obj.Look_And_Say(start, n);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

        }
        public static void NicoCipher()
        {
            NicoCipher obj = new NicoCipher();
            Console.WriteLine("Enter the Message");
            string msg = Console.ReadLine();
            Console.WriteLine("Enter Key");
            string key = Console.ReadLine();
            Console.WriteLine(obj.Nico_Cipher(msg, key));

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