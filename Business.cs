using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sql_dbfirst
{
    public class Business
    {
        private readonly IRepository<Student> _studentRepo;
        private readonly IRepository<Teacher> _teacherRepo;
        private readonly IRepository<Staff> _staffRepo;

        public Business(SchoolEntities context)
        {
            _studentRepo = new Repository<Student>(context);
            _teacherRepo = new Repository<Teacher>(context);
            _staffRepo = new Repository<Staff>(context);
        }

        public void DisplayAllStudents()
        {
            var students = _studentRepo.GetAll();
            Console.WriteLine("Students List:");
            foreach (var student in students)
            {
                Console.WriteLine($"Roll No: {student.roll_no}, Name: {student.name}");
            }
            Console.WriteLine();
        }

        public void AddStudent()
        {
            Console.WriteLine("Enter Student Roll No:");
            int rollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name:");
            string name = Console.ReadLine();

            var student = new Student { roll_no = rollNo, name = name };
            _studentRepo.Add(student);
            _studentRepo.Save();

            Console.WriteLine("Student Added Successfully.\n");
        }

        public void UpdateStudent()
        {
            Console.WriteLine("Enter Student Roll No to Update:");
            int rollNo = int.Parse(Console.ReadLine());

            var student = _studentRepo.GetById(rollNo);

            Console.WriteLine($"Current Name: {student.name}");
            Console.WriteLine("Enter Student Name to update:");
            string newName = Console.ReadLine();

            student.name = newName;
            _studentRepo.Update(student);
            _studentRepo.Save();

            Console.WriteLine("Student Record Updated Successfully!\n");
        }

        public void DeleteStudent()
        {
            Console.WriteLine("Enter Student Roll No to Delete:");
            int rollNo = int.Parse(Console.ReadLine());

            var student = _studentRepo.GetById(rollNo);

            _studentRepo.Delete(student);
            _studentRepo.Save();
            Console.WriteLine("Student Record Deleted Successfully!\n");
        }

        public void DisplayAllTeachers()
        {
            var teachers = _teacherRepo.GetAll();
            Console.WriteLine("Teachers List:");
            foreach (var teacher in teachers)
            {
                Console.WriteLine($"ID: {teacher.id}, Name: {teacher.name}, Subject: {teacher.subject_taught}");
            }
            Console.WriteLine();
        }

        public void AddTeacher()
        {
            Console.WriteLine("Enter Teacher ID:");
            int tid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Teacher Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Subject:");
            string subject = Console.ReadLine();

            var teacher = new Teacher { id = tid, name = name, subject_taught = subject };
            _teacherRepo.Add(teacher);
            _teacherRepo.Save();

            Console.WriteLine("Record Added Successfully.\n");
        }

        public void UpdateTeacher()
        {
            Console.WriteLine("Enter Teacher ID to Update:");
            int tid = int.Parse(Console.ReadLine());

            var teacher = _teacherRepo.GetById(tid);

            Console.WriteLine($"Current Name: {teacher.name}");
            Console.WriteLine("Enter Teacher Name to update:");
            string newName = Console.ReadLine();

            teacher.name = newName;
            _teacherRepo.Update(teacher);
            _teacherRepo.Save();

            Console.WriteLine("Teacher Record Updated Successfully!\n");
        }

        public void DeleteTeacher()
        {
            Console.WriteLine("Enter Teacher ID to Delete:");
            int tid = int.Parse(Console.ReadLine());

            var teacher = _teacherRepo.GetById(tid);

            _teacherRepo.Delete(teacher);
            _teacherRepo.Save();
            Console.WriteLine("Teacher Record Deleted Successfully!\n");
        }

        public void DisplayAllStaff()
        {
            var staff = _staffRepo.GetAll();
            Console.WriteLine("Staff List:");
            foreach (var s in staff)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Designation: {s.designation}");
            }
            Console.WriteLine();
        }

        public void AddStaff()
        {
            Console.WriteLine("Enter Staff ID:");
            int sid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Staff Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Designation:");
            string des = Console.ReadLine();

            var staff = new Staff { id = sid, name = name, designation = des };
            _staffRepo.Add(staff);
            _staffRepo.Save();

            Console.WriteLine("Student Added Successfully.\n");
        }

        public void UpdateStaff()
        {
            Console.WriteLine("Enter Staff ID to Update:");
            int sid = int.Parse(Console.ReadLine());

            var staff = _staffRepo.GetById(sid);

            Console.WriteLine($"Current Name: {staff.name}");
            Console.WriteLine("Enter Staff Name to update:");
            string newName = Console.ReadLine();

            staff.name = newName;
            _staffRepo.Update(staff);
            _staffRepo.Save();

            Console.WriteLine("Staff Record Updated Successfully!\n");
        }

        public void DeleteStaff()
        {
            Console.WriteLine("Enter Staff ID to Delete:");
            int sid = int.Parse(Console.ReadLine());

            var staff = _staffRepo.GetById(sid);

            _staffRepo.Delete(staff);
            _staffRepo.Save();
            Console.WriteLine("Teacher Record Deleted Successfully!\n");
        }

    }
}
