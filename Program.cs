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
            int choice;
            using (var context = new SchoolEntities())
            {
                var studentRepo = new Repository<Student>(context);
                var business = new Business(context);

                do
                {
                    Console.WriteLine("You can perform the following operations:");
                    Console.WriteLine("1. Display");
                    Console.WriteLine("2. Add");
                    Console.WriteLine("3. Update");
                    Console.WriteLine("4. Delete");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("1. Display Student Data");
                            Console.WriteLine("2. Display Teacher Data");
                            Console.WriteLine("3. Display Staff Data");
                            int ch = int.Parse(Console.ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    business.DisplayAllStudents();
                                    break;

                                case 2:
                                    business.DisplayAllTeachers();
                                    break;

                                case 3:
                                    business.DisplayAllStaff();
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Try again.");
                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("1. Insert Student Data");
                            Console.WriteLine("2. Insert Teacher Data");
                            Console.WriteLine("3. Insert Staff Data");
                            ch = int.Parse(Console.ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    business.AddStudent();
                                    break;

                                case 2:
                                    business.AddTeacher();
                                    break;

                                case 3:
                                    business.AddStaff();
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Try again.");
                                    break;
                            }
                            break;

                        case 3:
                            Console.WriteLine("1. Update Student Data");
                            Console.WriteLine("2. Update Teacher Data");
                            Console.WriteLine("3. Update Staff Data");
                            ch = int.Parse(Console.ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    business.UpdateStudent();
                                    break;

                                case 2:
                                    business.UpdateTeacher();
                                    break;

                                case 3:
                                    business.UpdateStaff();
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Try again.");
                                    break;
                            }
                            break;

                        case 4:
                            Console.WriteLine("1. Delete Student Data");
                            Console.WriteLine("2. Delete Teacher Data");
                            Console.WriteLine("3. Delete Staff Data");
                            ch = int.Parse(Console.ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    business.DeleteStudent();
                                    break;

                                case 2:
                                    business.DeleteTeacher();
                                    break;

                                case 3:
                                    business.DeleteStaff();
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice. Try again.");
                                    break;
                            }
                            break;

                        case 5:
                            break;
                        
                        default:
                            Console.WriteLine("Invalid choice. Try again.");
                            break;
                    }
                } while (choice != 5);

            }
        }
    }
}
