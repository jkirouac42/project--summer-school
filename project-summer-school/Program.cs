using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_summer_school
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Hogwart's Student Enrollment System");
            students = newstring[15]
            while (true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    EnrollStudent();//create method
                }
            }
        }
        static void EnrollStudent()
        {
            Console.WriteLine("Enter students name.");
            string[] newStudent = new string[15];
            string student = Console.ReadLine();
            for (int index = 0; index < newStudent.Length; index++)
            {
                newStudent[index] = Console.ReadLine();
                break;
            }


        }

    }
}
