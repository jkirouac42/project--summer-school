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
            string[] newStudent = new string[15];
           
            Console.WriteLine("Welcome to the Hogwart's Student Enrollment System");
            Console.WriteLine("To enroll a student please select 1");
            
            while (true)
            {
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    EnrollStudent(newStudent);//static void method
                    Console.WriteLine("To enroll another press 1");
                }
                else if (newStudent[14] != null)
                {
                    RemoveStudent(newStudent);
                }

            }

        }
        static void EnrollStudent(string[] newstudent)
        {
            Console.WriteLine("Enter students name.");
            string student = Console.ReadLine();
            
            for (int i = 0; i < 15; i++)
                if (newstudent[i] == null) 
            {
                    newStudent[i] = student;
                    break;
            }
            
            
            
            


            //if (newStudent[0] == null)
            //{
            //    newStudent[0] = "0. " + student;
            //}
            //else if (newStudent[1] == null)
            //{
            //    newStudent[1] = "1. " + student;
            //}
            //else if (newStudent[2] == null)
            //{
            //    newStudent[2] = "2. " + student;
            //}
            //else if (newStudent[3] == null)
            //{
            //    newStudent[3] = "3. " + student;
            //}
            //else if (newStudent[4] == null)
            //{
            //    newStudent[4] = "4. " + student;
            //}
            //else if (newStudent[5] == null)
            //{
            //    newStudent[5] = "5. " + student;
            //}
            //else if (newStudent[6] == null)
            //{
            //    newStudent[6] = "6. " + student;
            //}
            //else if (newStudent[7] == null)
            //{
            //    newStudent[7] = "7. " + student;
            //}
            //else if (newStudent[8] == null)
            //{
            //    newStudent[8] = "8. " + student;
            //}
            //else if (newStudent[9] == null)
            //{
            //    newStudent[9] = "9. " + student;
            //}
            //else if (newStudent[10] == null)
            //{
            //    newStudent[10] = "10. " + student;
            //}
            //else if (newStudent[11] == null)
            //{
            //    newStudent[11] = "11. " + student;
            //}
            //else if (newStudent[12] == null)
            //{
            //    newStudent[12] = "12. " + student;
            //}
            //else if (newStudent[13] == null)
            //{
            //    newStudent[13] = "13. " + student;
            //}
            //else if (newStudent[14] == null)
            //{
            //    newStudent[14] = "14. " + student;
            //    Console.WriteLine("Roster is now full.");
            //}
           
            
            
            
        }
        static void RemoveStudent(string[] newstudent)
          {
            Console.WriteLine(newstudent);
            Console.WriteLine("Enter the number of the student you wish to remove.");
            int student = int.Parse(Console.ReadLine());

            if (student == 0)
            {
                newstudent[0] = null;
            }
            else if (student == 1)
            {
                newstudent[1] = null;
            }
            else if (student == 2)
            {
                newstudent[2] = null;
            }
            else if (student == 3)
            {
                newstudent[3] = null;
            }
            else if (student == 4)
            {
                newstudent[4] = null;
            }
            else if (student == 5)
            {
                newstudent[5] = null;
            }
            else if (student == 6)
            {
                newstudent[6] = null;
            }
            else if (student == 7)
            {
                newstudent[7] = null;
            }
            else if (student == 8)
            {
                newstudent[8] = null;
            }
            else if (student == 9)
            {
                newstudent[9] = null;
            }
            else if (student == 10)
            {
                newstudent[10] = null;
            }
            else if (student == 11)
            {
                newstudent[11] = null;
            }
            else if (student == 12)
            {
                newstudent[12] = null;
            }
            else if (student == 13)
            {
                newstudent[13] = null;
            }
            else if (student == 14)
            {
                newstudent[14] = null;
            }
            else
            {
                
            }


          }

    }

}
   

