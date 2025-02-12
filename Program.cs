using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_dbfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolEntities())
            {
                var studentRepo = new Repository<Student>(context);
                
                // Display all students
                Console.WriteLine("Students List:");
                var students = studentRepo.GetAll();
                foreach (var student in students)
                {
                    Console.WriteLine($"Roll No: {student.roll_no}, Name: {student.name}");
                }
                Console.WriteLine();

                // Insert new student
                Console.WriteLine("Enter Student Roll No:");
                int rollNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student Name:");
                string name = Console.ReadLine();

                var newStudent = new Student { roll_no = rollNo, name = name };
                studentRepo.Add(newStudent);
                studentRepo.Save();
                Console.WriteLine("Student Added Successfully.\n");

            }
        }
    }
}
