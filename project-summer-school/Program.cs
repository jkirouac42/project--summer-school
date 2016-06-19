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
            string[] newStudent = new string[15];
           
            Console.WriteLine("Welcome to the Hogwart's Student Enrollment System");
            Console.WriteLine("To enroll a student please select 1");
            
            while (true)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    EnrollStudent(newStudent);//static void method
                    Console.WriteLine("To enroll another press 1");
                }
                else if (choice == 2)
                {
                    RemoveStudent(newStudent);
                }
            }

        }
        static void EnrollStudent(string[] newstudent)
        {
            Console.WriteLine("Enter students name.");
            string[] newStudent = new string[15];
            string student = Console.ReadLine();
           

            if (newStudent[0] == null)
            {
                newStudent[0] = "1. " + student;
            }
            else if (newStudent[1] == null)
            {
                newStudent[1] = "2. " + student;
            }
            else if (newStudent[2] == null)
            {
                newStudent[2] = "3. " + student;
            }
            else if (newStudent[3] == null)
            {
                newStudent[3] = "4. " + student;
            }
            else if (newStudent[4] == null)
            {
                newStudent[4] = "5. " +  student;
            }
            else if (newStudent[5] == null)
            {
                newStudent[5] = "6. " + student;
            }
            else if (newStudent[6] == null)
            {
                newStudent[6] = "7. " + student;
            }
            else if (newStudent[7] == null)
            {
                newStudent[7] = "8. " + student;
            }
            else if (newStudent[8] == null)
            {
                newStudent[8] = "9. "  + student;
            }
            else if (newStudent[9] == null)
            {
                newStudent[9] = "10. "  + student;
            }
            else if (newStudent[10] == null)
            {
                newStudent[10] = "11. " + student;
            }
            else if (newStudent[11] == null)
            {
                newStudent[11] = "12. " +  student;
            }
            else if (newStudent[12] == null)
            {
                newStudent[12] = "13. " + student;
            }
            else if (newStudent[13] == null)
            {
                newStudent[13] = "14. " + student;
            }
            else if (newStudent[14] == null)
            {
                newStudent[14] = "15. " + student;
            }
            else
            {
                Console.WriteLine("Roster is now full."); 
            } 



        }
        static void RemoveStudent(string[] newstudent)
            {
            Console.WriteLine(newstudent);            
            }
        }
}
   

