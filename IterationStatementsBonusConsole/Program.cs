using System;

namespace IterationStatementsBonusConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //print #s from 1000 to -1000
            Print1000();

            //print #s 3-999 by 3 each time
            PrintBy3s();

            //accept 2 integers and determine if they are equal or not
            int userNum1 = UserNumber();
            int userNum2 = UserNumber();
            bool equal = NumbersAreEqual(userNum1, userNum2);
            Console.WriteLine($"{userNum1} is equal to {userNum2} : {equal}");

            //get user number and determine if it is even or odd
            int userNum3 = GetUserNum();
            EvenOrOdd(userNum3);

            //Determine is user number is even or odd

            int userNum4 = GetUserNum2();
            PosOrNeg(userNum4);

            //Determine if a candidate is old enough to vote
            int userAge = GetUserAge();
            OldEnough(userAge);
       
        }
        //print #s from 1000 to -1000
        public static void Print1000()

        {
            for (int i = 1000; i >= -1000; i--)

                Console.WriteLine(i);

        }
        //print #s 3-999 by 3 each time
        public static void PrintBy3s()
        {
            for (int i = 3; i <= 999; i += 3)
                Console.WriteLine(i);
        }
        //accept 2 integers and determine if they are equal or not
        public static int UserNumber()
        {
            Console.WriteLine("Give me a number to check for equality:");

            int userNum = int.Parse(Console.ReadLine());
            return userNum;



        }
        public static bool NumbersAreEqual(int userNum1, int userNum2)

        {
            return userNum1 == userNum2;
        }

        //get user number and determine if it is even or odd

        public static int GetUserNum()
        {
         Console.WriteLine("Give me a number to check for even or odd:");

            int userNum = int.Parse(Console.ReadLine());
            return userNum;
          }
        public static void EvenOrOdd(int userNum3)

        { if (userNum3 % 2 == 0)
                Console.WriteLine($"{userNum3} is even!");

            else if (userNum3 % 2 != 0)
                Console.WriteLine($"{userNum3} is odd!");
            else Console.WriteLine("Im confused, please re-run the program!");
        }
        //Check whether number is positive or negative
        public static int GetUserNum2()
        {
            Console.WriteLine("Give me a number to check for positive or negative:");

            int userNum = int.Parse(Console.ReadLine());
            return userNum;
        }
        public static void PosOrNeg(int userNum4)
        {
            if (userNum4 >= 0)
                Console.WriteLine($"{userNum4} is a positive integer!");
            else if (userNum4 < 0)
                Console.WriteLine($"{userNum4} is a negative integer!");
            else
                Console.WriteLine("Im confused, please re-run the program.");
        }

        //Determine if user is old enough to vote

        public static int GetUserAge()
        {
            Console.WriteLine("Please enter your current age:");
            int userAge = int.Parse(Console.ReadLine());
            return userAge;
            }

        public static void OldEnough(int userAge)
        {if (userAge >= 18)
                    Console.WriteLine("Great, you are old enough to vote!");
                else if (userAge < 18)
                    Console.WriteLine("Im sorry, you are not old enough to vote");
                else Console.WriteLine("Im confused, please re-enter your information");

        }











    }
}
