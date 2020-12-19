using System;
using System.Collections.Generic;

namespace ConsoleApp3
{class Program
    {
        static void angryProfessor(int threshold, int[] student)
        {


            for (int i = 0; i < n; i++)
            {
                if (student[i] <= 0 && student[i] > -100)
                {
                    arrivalTime += 1;
                }

                else if (student[i] > 0 && student[i] <= 100)
                {
                    arrivalTime += 0;
                }
                else
                {
                    Console.WriteLine("arrival time can't be less than -100 or more than 100");
                }
            }
            if (arrivalTime <= k)
            {

                res.Add("Yes");
            }
            else
            {
                res.Add("No");
            }
        }
        //The first line has two space-separated integers, n and k,
        static int n,k,arrivalTime;
        static List<string> res = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Number of test cases:");
            // The first line of input contains t, the number of test cases.
            int t = Convert.ToInt32(Console.ReadLine());
            
            if (t >= 1 && t <= 10)
            {
                for (int i = 0; i < t; i++)
                {
                    //Second Constraint
                    Console.WriteLine("Number of students:");
                    string[] students = Console.ReadLine().Split(' ');
                    n = Convert.ToInt32(students[0]);
                    k = Convert.ToInt32(students[1]);
                    if (n >= 1 && n <= 1000)
                    {
                        if (k >= 1 && k <= n)
                        {
                            Console.WriteLine("Arrival times of students:");
                            string[] temp = Console.ReadLine().Split(' ');
                            int[] a = Array.ConvertAll(temp, Int32.Parse);

                            if (a.Length == n)
                            {
                                angryProfessor(k, a);
                            }
                            // Condition that states if a != n
                            else
                            {
                                Console.WriteLine("Number of students should be equal to n");
                            }
                        }
                        //For invalid value of k
                        else 
                        {
                            Console.WriteLine("Invalid Threshold number. The value should be in range " + n);
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number of Students should be within range");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number of test cases, value should be between 1 and 10");
            }

            Console.WriteLine("Is class cancelled?");
            foreach (string i in res)
            {
                Console.WriteLine(i);
            }
        }
        //angryProfessor function It must return YES if class is cancelled, or NO otherwise
       


    }
}
