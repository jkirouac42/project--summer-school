using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_summer_school
{
    class Program
    {
        static string[] newStudent = new string[15];
        static double[] Tuition = new double[15];
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Hogwart's Student Enrollment System\n");

            while (true)
            {
                Console.WriteLine("\nTo enroll a student press 1");
                Console.WriteLine("To remove student press 2");
                Console.WriteLine("Print enrollment list press 3\n");
                Console.WriteLine("Exit program press 4"); //break

                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    EnrollStudent();//static void method
                }
                if (choice == 2)
                {
                    RemoveStudent();
                }
                if (choice == 3)
                {
                    PrintList();
                }
                else if (choice == 4)
                {
                    break;
                }

            }


        }
        static void EnrollStudent()
        {
            Console.WriteLine("Enter students name.");
            string student = Console.ReadLine();

            double Cost = 200;

            for (int i = 0; i < newStudent.Length; i++)

                if (student.Contains("Malfoy"))
                {
                    Console.WriteLine("Student cannot be enrolled");
                    break;
                }

                else if (student.ToLower() == "tom")
                {
                    Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");
                    newStudent[i] = student;
                    Tuition[i] = Cost;

                }

                else if (student.ToLower() == "riddle")
                {
                    Console.WriteLine("RED ALERT!!! HE WHO MUST NOT BE NAMED!!!");
                    newStudent[i] = student;
                    Tuition[i] = Cost;
                    break;

                }

                else if (student.ToLower() =="voldemort")
                {
                    Console.WriteLine("Lool up special case");
                    newStudent[i] = student;
                    Tuition[i] = Cost;
                    break;
                }

                else if (student.Contains("Longbottom") && (newStudent[i] == null))
                {
                    Console.WriteLine("Tuition is waived");
                    newStudent[i] = student;
                    Tuition[i] = Cost - 200;
                    break;
                }

                else if (student.Contains("Potter") && (newStudent[i] == null))
                {
                    Console.WriteLine("Got you a discount");
                    newStudent[i] = student;
                    Tuition[i] = Cost * .5;
                    break;
                }

                else if (newStudent[i] == null)
                {
                    newStudent[i] = student;
                    Tuition[i] = Cost;
                    Console.WriteLine("You entered \n" + student);
                    break;
                }
            //for (int i = 0; i < Tuition.Length; i++)

            //    if (student.Contains("Longbottom"))
            //    {
            //        Tuition[i] = Cost - 200;
            //    }

            //    else if (student.Contains("Potter"))
            //    {
            //        Tuition[i] = Cost * .5;
            //    }

            //    else
            //    {
            //        Tuition[i] = Cost;
            //    }


            // else if()



        }
        static void RemoveStudent()
        {

            PrintList();
            Console.WriteLine("Enter the number of the student you wish to remove.");
            int student = int.Parse(Console.ReadLine());

            Console.WriteLine(newStudent);

            for (int i = 0; i < newStudent.Length; i++)
            {

                if (i == student)
                {
                    Console.WriteLine("You entered " + student);
                    newStudent[i - 1] = null;
                    break;
                }
            }
        }
        static void PrintList()
        {
            for (int i = 0; i < newStudent.Length; i++)

            {
                if (newStudent[i] != null)
                    Console.WriteLine(i + 1 + ". " + newStudent[i] + " " + "£" + Tuition[i]);
            }
        }
    }
}

