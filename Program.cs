using System;

namespace _2nd_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Level 1

            #region Task 1.1

            int r = 2;
            double x1 = 0, y1 = 2;
            double x2 = 1.5, y2 = 0.7;
            double x3 = 1, y3 = 1;
            double x4 = 3, y4 = 0;

            Console.WriteLine("answer for task 1.1:");

            if (Math.Abs(x1 * x1 + y1 * y1 - r * r) <= Math.Pow(10, -3)) Console.WriteLine("1: yes");
            else Console.WriteLine("1: no");

            if (Math.Abs(x2 * x2 + y2 * y2 - r * r) <= Math.Pow(10, -3)) Console.WriteLine("2: yes");
            else Console.WriteLine("2: no");

            if (Math.Abs(x3 * x3 + y3 * y3 - r * r) <= Math.Pow(10, -3)) Console.WriteLine("3: yes");
            else Console.WriteLine("3: no");

            if (Math.Abs(x4 * x4 + y4 * y4 - r * r) <= Math.Pow(10, -3)) Console.WriteLine("4: yes\n");
            else Console.WriteLine("4: no\n");

            #endregion

            #region Task 1.3

            double a, b;

            Console.WriteLine("solution for task 1.3:");

            do
            {
                Console.Write("enter value \"a\": ");
            }
            while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("enter value \"b\": ");
            }
            while (!double.TryParse(Console.ReadLine(), out b));

            if (a > 0) Console.WriteLine($"answer for task 1.3:\nc = {Math.Max(a, b)}\n");
            else Console.WriteLine($"answer for tast 1.3:\nc = {Math.Min(a, b)}\n");

            #endregion

            #region Task 1.4

            Console.WriteLine("solution for task 1.4:");

            double c;

            do
            {
                Console.Write("enter value \"a\": ");
            }
            while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("enter value \"b\": ");
            }
            while (!double.TryParse(Console.ReadLine(), out b));

            do
            {
                Console.Write("enter value \"c\": ");
            }
            while (!double.TryParse(Console.ReadLine(), out c));

            Console.WriteLine("\nanswer for Task 1.4: ");

            Console.WriteLine($"z = {Math.Max(Math.Min(a, b), c)}\n");

            #endregion

            #endregion

            #region Level 2

            #region Task 2.1

            Console.WriteLine("solution for task 2.1:");

            int n;
            double s_height = 0;

            do
            {
                Console.Write("enter the number of students: ");
            }

            while (!int.TryParse(Console.ReadLine(), out n));



            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i} student: ");
                if (double.TryParse(Console.ReadLine(), out double height))
                {
                    if (height > 0)
                        s_height += height;

                    else
                    {
                        Console.WriteLine("enter the correct height ( |n| > 0 )");
                        i--;
                    }

                }

                else
                {
                    Console.WriteLine("enter the correct height (number!)");
                    i--;
                }
            }

            if (n == 0) Console.WriteLine("answer for task 2.1: no students\n");

            else Console.WriteLine($"answer for task 2.1: {(s_height / n):f2} cm\n");

            #endregion

            #region Task 2.2

            Console.WriteLine("solution for task 2.2:");

            double x, y;

            do
            {
                Console.Write("enter the number of points: ");
            }

            while (!int.TryParse(Console.ReadLine(), out n));

            do
            {
                Console.Write("enter radius: ");
            }

            while (!int.TryParse(Console.ReadLine(), out r));

            do
            {
                Console.Write("enter \"a\" (radius center coordinate): ");
            }

            while (!double.TryParse(Console.ReadLine(), out a));

            do
            {
                Console.Write("enter \"b\" (radius center coordinate): ");
            }

            while (!double.TryParse(Console.ReadLine(), out b));


            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {

                do
                {
                    Console.Write($"enter \"x{i}\" (point coordinate): ");
                }

                while (!double.TryParse(Console.ReadLine(), out x));

                do
                {
                    Console.Write($"enter \"y{i}\" (point coordinate): ");
                }

                while (!double.TryParse(Console.ReadLine(), out y));

                if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) <= r * r) Console.WriteLine($"{i} point: yes\n");
                else Console.WriteLine($"{i} point: no\n");
            }

            #endregion

            #endregion

            #region Level 3

            #region Task 3.4

            Console.WriteLine("Solution for task 3.4:");

            double r1, r2;

            do
            {
                Console.Write("enter the number of points: ");
            }

            while (!int.TryParse(Console.ReadLine(), out n));

            do
            {
                Console.Write("enter inner radius: ");
            }

            while (!double.TryParse(Console.ReadLine(), out r1));

            do
            {
                Console.Write("enter outer radius: ");
            }

            while (!double.TryParse(Console.ReadLine(), out r2));

            Console.WriteLine("");

            if (r1 > r2) Console.WriteLine("inner radius cannot be greater than outer (task skipped)\n");
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    do
                    {
                        Console.Write($"enter \"x{i}\" (point coordinate): ");
                    }

                    while (!double.TryParse(Console.ReadLine(), out x));

                    do
                    {
                        Console.Write($"enter \"y{i}\" (point coordinate): ");
                    }

                    while (!double.TryParse(Console.ReadLine(), out y));

                    if ((x * x + y * y > r1 * r1) && (x * x + y * y < r2 * r2)) Console.WriteLine($"{i} point: yes\n");
                    else Console.WriteLine($"{i} point: no\n");
                }
            }

            #endregion

            #region Task 3.11

            Console.WriteLine("solution for task 3.11:");

            double score, sum_score, unsuccessful = 0, final_sum_score = 0;
            bool unsuccessful_bool;

            do
            {
                Console.Write("enter number of students: ");
            }

            while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 1; i <= n; i++) // student
            {

                unsuccessful_bool = false;

                sum_score = 0;

                for (int j = 1; j <= 4; j++) // subject
                {

                    do
                    {
                        Console.Write($"enter result of {i} student for {j} subject: ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out score));

                    if (score < 2.5) unsuccessful_bool = true;

                    sum_score += score;

                }

                if (unsuccessful_bool) unsuccessful += 1;

                final_sum_score += sum_score;

            }

            Console.WriteLine($"Answer for task 3.11:\nnumber of failing students: {unsuccessful}\n" +
                $"group average: {(final_sum_score / (n * 4)):f2}\n");

            #endregion

            #region Task 3.12

            Console.WriteLine("solution for task 3.12:");

            int choice;

            do
            {
                Console.Write("enter the number of values: ");
            }

            while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("enter the value of \"r\": ");
                }

                while (!int.TryParse(Console.ReadLine(), out r));

                do
                {
                    Console.Write("\nSelect an action (enter the desired number):\n" +
                        "area of a square with side \"r\" - 1\n" +
                        "area of a circle with radius \"r\" - 2\n" +
                        "area of an equilateral triangle with side \"r\" - 3\n" +
                        "to skip - enter any other number\n\nchoise: ");
                }

                while (!int.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"square area = {r * r}\n");
                        break;

                    case 2:
                        Console.WriteLine($"circle area = {(Math.PI * (r * r)):f2}\n");
                        break;

                    case 3:
                        Console.WriteLine($"area of an equilateral triangle = {((Math.Sqrt(3) / 4) * (r * r)):f2}\n");
                        break;

                    default:
                        Console.WriteLine($"task skipped (different number entered)\n");
                        break;
                }
            }

            #endregion

            #region Task 3.13

            Console.WriteLine("solution for task 3.13:");

            do
            {
                Console.Write("enter the number of values: ");
            }

            while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 0; i < n; i++)
            {
                do
                {
                    Console.Write("enter value \"a\": ");
                }
                while (!double.TryParse(Console.ReadLine(), out a));

                do
                {
                    Console.Write("enter value \"b\": ");
                }
                while (!double.TryParse(Console.ReadLine(), out b));

                do
                {
                    Console.Write("\nSelect an action (enter the desired number):\n" +
                        "area of a rectangle - 1\n" +
                        "area of a ring enclosed between two circles - 2\n" +
                        "area of an isosceles triangle with sides A, B, B - 3\n" +
                        "to skip - enter any other number\n\nchoise: ");
                }

                while (!int.TryParse(Console.ReadLine(), out choice));

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"area of rectangle = {a * b}\n");
                        break;

                    case 2:
                        Console.WriteLine($"area of a ring enclosed between two circles = " +
                            $"{(Math.Abs(Math.PI * (a * a - b * b))):f2}\n");
                        break;

                    case 3:
                        Console.WriteLine($"area of an isosceles triangle = " +
                            $"{((a / 4.0) * Math.Sqrt(Math.Abs(4.0 * (a * a) - (b * b)))):f2}\n");
                        break;

                    default:
                        Console.WriteLine($"task skipped (different number entered)\n");
                        break;
                }

            }

            #endregion

            #endregion

        }
    }
}
