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
            Console.WriteLine("Please select from our menu.\nEnrollment select 1");
            Console.WriteLine("To remove student select 2");
            while (true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    EnrollStudent();//static void method
                    Console.WriteLine("Should you want to enroll another\nPlease press 1");
                    Console.WriteLine("To return to the main menu please press 5");
                }
                else if (choice == 2)
                {
                    RemoveStudent();
                }
            }

        }
        static void EnrollStudent()
        {
            Console.WriteLine("Enter students name.");
            string[] newStudent = new string[15];
            string student = Console.ReadLine();
            
            for (int index = 0; index < newStudent.Length; index ++)
                {
                newStudent[index] = student;
                    break;               
                }
                Console.WriteLine("You enrolled: "+ newStudent);
            for (int index = 0; index < 15; index++)
                {
                Console.WriteLine(newStudent[index]);              
                }

        }
        
    }static void RemoveStudent()
    {
        Console.WriteLine("Enter students name.");
        string[] newStudent = new string[15];
        string student = Console.ReadLine();

        for (int index = 0; index < newStudent.Length; index++)
        {
            newStudent[index] = null;
            break;
        }
        Console.WriteLine("You removed: " + newStudent);
        for (int index = 0; index < 15; index++)
        {
            Console.WriteLine(newStudent[index]);
        }
    }
}

