using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Grade_caculator_Q5_Assessment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            double num1, num2, num3, num4;
            double avg;
            Console.Write("Number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 3: ");
            num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 4:");
            num4 = Convert.ToDouble(Console.ReadLine());
            avg = calculate_average(num1, num2, num3, num4);
            Console.WriteLine("The average of three numbers is " + avg);



            Console.ReadKey();
        }

        public static double calculate_average(double n1, double n2, double n3, double n4)
        {
            double avrg = (n1 + n2 + n3 + n4) / 4;
            return avrg;
            */

        }
        public static double students_grade(double a, double b, double c, double d, double f, double g)
        {

            if (a >= 80)
            {
                a = 'A';
                Console.WriteLine("your grade is " + a);
            }
            else if (b >= 70 && b < 80)
            {
                b = 'B';
                Console.WriteLine("your grade is " + b);
            }
            else if (c >= 60 && c < 70)
            {
                c = 'C';
                Console.WriteLine("your grade is " + c);
            }
            else if (d >= 50 && d < 60)
            {
                d = 'D';
                Console.WriteLine("your grade is " + d);
            }
            else if (f < 50)
            {
                Console.WriteLine(" you don't pass " + f);
            }

            {
                g = 'f';
            }

            return g;
            Console.ReadKey();

        
      
        

            /*
            Ask the user to input marks for 4 subjects(Maths, Physics, Chemistry and Computer
             Science) out of a maximum of 100
             b.Use a function to calculate the average of the 4 marks and return it
             c.Use a function to find out the grade of the student using the average marks following
             the criteria listed below
                       • Marks >= 80 – Grade A
                       • Marks >= 70 and < 80 – Grade B
                       • Marks >= 60 and < 70 – Grade C
                       • Marks >= 50 and < 60 – Grade D
                       • Marks < 50 – Grade F
            d.Using a switch statement, print remarks listed below based on the grade
                       • Grade A – ‘Excellent! Your grade is A’
                       • Grade B – ‘Good! Your grade is B’
                       • Grade C – ‘Satisfactory.Your grade is C’
                       • Grade D – ‘Pass.Your grade is D’
                       • Grade F – ‘Fail.Your grade is F’




            /*
            // Sort the array

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 19 };
            Array.Sort(a);

            int sum = 0;

            for (int i = 0; i <= 10; i++)
            {

                // If current element
                // satisfies the condition
                if (sum + (a[i] * (10 - i)) == S)
                    return a[i];
                sum += a[i];
            }

            // No element found
            return -1;
        }

        // Driver code
        public static void Main()
        {

            int S = 10;
            int[] a = { 1, 3,4,5,6,7,8,9,10};
            int n = a.Length;

            Console.WriteLine(getElement(a, n, S));
        }
            */
                /*
                  Age_group obj_age_group = new Age_group();
                string name, age_group;
                DateTime dob;

                Console.WriteLine("Please enter the name");
                name = Console.ReadLine();
                Console.WriteLine("Please enter the Date of Birth (yyyy-mm-dd)");
                dob = Convert.ToDateTime(Console.ReadLine());

                //DateTime Obj_today = DateTime.Today;
                //int age = Obj_today.Year - dob.Year;

                int age = obj_age_group.person_age(dob);
                age_group = obj_age_group.Person_Age_Group(age);

                try
                {
                    switch (age_group)
                    {
                        case "Senior Citizen":
                            {
                                Console.WriteLine("Walk is good for you");
                                break;
                            }
                        case "Middle Adult":
                            {
                                Console.WriteLine("2 days a week of activities that strengthen muscles is good for you");
                                break;
                            }
                        case "Young Adult":
                            {
                                Console.WriteLine("5 days a week of activities that strengthen muscles is good for you");
                                break;
                            }
                        case "Adolescents":
                            {
                                Console.WriteLine("Play more outdoor games");
                                break;
                            }
                        case "Children":
                            {
                                Console.WriteLine("Eating less sugar is good for you’");
                                break;
                            }
                        case "Toddlers":
                            {
                                Console.WriteLine("Don’t go with stranger");
                                break;
                            }
                        case "Infants":
                            {
                                Console.WriteLine("Enjoy");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid");
                                break;
                            }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Console.ReadKey();
            }
            */
        }

        

    }
}
