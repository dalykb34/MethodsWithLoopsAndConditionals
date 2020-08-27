using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(NumberMatch(6, 7));

            CountDown();

            BeyondTheArc();

            //IsPositive(5);

            Console.WriteLine($"How old is potential voter?");
            var userInput = Console.ReadLine();
            var age = int.Parse(userInput);
            CanVote(age);

            CreateRandoArray();


            //Console.WriteLine(EvenOrOdd();
            
            //Console.WriteLine($"give me a number");
            //int.Parse(Console.ReadLine());

            //for (var b = 3, b>= 999, b += 3)
            //{
            //    Console.WriteLine("{b}");
            //}


        }
        public static bool NumberMatch(int a, int b) 
        {
            if(a != b) 
            {
                return false;
            }
            else 
            {
                return true;
            }
        }
        
        public static void CountDown()
        {
            
                for (int i = 1000; i >= -1000; i--)
                {
                Console.WriteLine($"{i} and another one down!");
                }
        }

        public static void BeyondTheArc() 
        {
            for(var c=3; c < 1000; c += 3) 
            {
                Console.WriteLine($"{c}pts!");
            }
        }

        //public static void EvenOrOdd(int number)
        //{

        //    if (number = % 2 == 0)
        //    {
        //        Console.WriteLine($"that's even");
        //    }
        //    else
        //    {
        //        Console.Write($"odd");
        //    }
        //}
        public static bool IsPositive(int num1) 
        {
          if( num1 > 0)
            {
                return true;
            }
            else if(num1 == 0)
            {
                return false;
            }
            
            else
            {
                return false;
            }
        }

        public static bool CanVote(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine($"Yes you can vote");
                return true;
            }
            else
            {
                Console.WriteLine($"No you cannot vote.");
                return false;
            }
        }
        //heating up#3
        public static int[] CreateRandoArray()
        {
            Console.WriteLine($"How many items would you like in your array?");

            var userInput = int.Parse(Console.ReadLine());

            var newArray = new int[userInput];

            for (int i = 0; i < newArray.Length; i++)
            {
                var random = new Random();
                newArray[i] = random.Next(1, 3000);
            }

            return newArray;
        }

    }
}
