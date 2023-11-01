using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssisteddProjecct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
            Console.ReadLine();
        }

        public static void runApp()
        {

            Teacher teacher = new Teacher();
            teacher.Name = "Mr.Jack";
            teacher.Address = "Hyderabd";
            teacher.DateOfJoining = DateTime.Today;

            Student student = new Student();
            student.Name = "John";
            student.Address = "Banglore";
            student.DateOfJoining = DateTime.Today;

            OfficeStaff staff = new OfficeStaff();
            staff.Name = "Mr.Kernel";
            staff.Address = "Mumbai";
            staff.DateOfJoining = DateTime.Today;


            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
        }
    }
}

        
