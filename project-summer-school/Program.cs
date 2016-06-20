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
        static void Main(string[] args)

        {
            Console.WriteLine("Welcome to the Hogwart's Student Enrollment System");
            
            while (true)
            {
                Console.WriteLine("To enroll a student press 1\n");
                Console.WriteLine("To remove student press 2");
                Console.WriteLine("Print enrollment list press 3");
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
            double cost = 200;
            for (int i = 0; i < newStudent.Length; i++)
                if (newStudent[i] == null)
                {
                    newStudent[i] = student;
                    Console.WriteLine("You entered " + student);
                    break;
                }


        }
        static void RemoveStudent()
        {
            Console.WriteLine(newStudent);
            Console.WriteLine("Enter the number of the student you wish to remove.");
            int student = int.Parse(Console.ReadLine());

            Console.WriteLine(newStudent);
            Console.WriteLine("Enter name of student you wish to remove.");

            for (int i = 0; i < newStudent.Length; i++)
            {
                if (i == student)
                {
                    newStudent[i] = null;
                    break;
                }
            }
        }
        static void PrintList()
        {
            for (int i = 0; i < newStudent.Length; i++)
            {
                Console.WriteLine(newStudent[i]);
            }
        }
        static void Cost()
        {
            double Cost = 200;
            for (int i =0; i < newStudent.Length; i++)
            Console.WriteLine(newStudent + "(£200)");
        }
    }
}

