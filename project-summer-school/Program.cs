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
            Console.WriteLine("To enroll a student please select 1.");
            
            while (true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    EnrollStudent();//static void method
                    Console.WriteLine("Enter name to enroll another press 1");
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

            if (newStudent[0] == null)
            {
                newStudent[0] = student;
            }
            else if (newStudent[1] == null)
            {
                newStudent[1] = student;
            }
            else if (newStudent[2] == null)
            {
                newStudent[2] = student;
            }
            else if (newStudent[3] == null)
            {
                newStudent[3] = student;
            }
            else if (newStudent[4] == null)
            {
                newStudent[4] = student;
            }
            else if (newStudent[5] == null)
            {
                newStudent[5] = student;
            }
            else if (newStudent[6] == null)
            {
                newStudent[6] = student;
            }
            else if (newStudent[7] == null)
            {
                newStudent[7] = student;
            }
            else if (newStudent[8] == null)
            {
                newStudent[8] = student;
            }
            else if (newStudent[9] == null)
            {
                newStudent[9] = student;
            }
            else if (newStudent[10] == null)
            {
                newStudent[10] = student;
            }
            else if (newStudent[11] == null)
            {
                newStudent[11] = student;
            }
            else if (newStudent[12] == null)
            {
                newStudent[12] = student;
            }
            else if (newStudent[13] == null)
            {
                newStudent[13] = student;
            }
            else if (newStudent[14] == null)
            {
                newStudent[14] = student;
            }
            else
            {
                for (int index = 0;index > 0; index++)
                {
                    Console.WriteLine(index);
                }

            } 



        }
        static void RemoveStudent()
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
}   

