using System;

namespace SharpCats
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Start();
        }

		public static void Start()
		{
			Console.WriteLine("Put in 2 numbers");
			float number1 = float.Parse(Console.ReadLine());
			float number2 = float.Parse(Console.ReadLine());
			Console.WriteLine("Select an option\n1.-Add\n2.-Subtract\n3.-Multiply\n4.-Divide\n5.-nope out");
			int option = int.Parse(Console.ReadLine());
			EvaluateOption(option, number1, number2);
		}

		public static float AddTwoNumbers(float n1, float n2)
		{
			float result = n1 + n2;

			return result;
		}

		public static float SubTwoNumbers(float n1, float n2)
		{
			float result = n1 - n2;

			return result;
		}

		public static float MultiplyTwoNumbers(float n1, float n2)
		{
			float result = n1 * n2;

			return result;
		}

		public static float DivideTwoNumbers(float n1, float n2)
		{
			float result = n1/n2;

			return result;
		}

		public static void EvaluateOption(int option, float n1, float n2)
		{
			switch (option)
			{
				case 1:
					Console.WriteLine("Result of addition: " + AddTwoNumbers(n1, n2));
					break;
				case 2:
					Console.WriteLine("Result of subtraction: " + SubTwoNumbers(n1, n2));
					break;
				case 3:
					Console.WriteLine("Result of multiplication: " + MultiplyTwoNumbers(n1, n2));
					break;
				case 4:
					Console.WriteLine("Result of division: " + DivideTwoNumbers(n1, n2));
					break;
				case 5:
					Console.WriteLine("Bye, wew");
					return;
				default:
					Console.WriteLine("Invalid Option");
					break;
			}

			Start(); //do again
		}
    }
}
