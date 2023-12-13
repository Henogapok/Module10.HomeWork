using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.HomeWork
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Teacher: {FirstName} {LastName}");
            if (Students != null)
            {
                Console.WriteLine("Students:");
                foreach (var student in Students)
                {
                    Console.WriteLine($"- {student.FirstName} {student.LastName}");
                }
            }
        }

        public static Teacher RandomTeacher()
        {
            // Генерация случайного преподавателя
            return new Teacher
            {
                FirstName = "TeacherName",
                LastName = "TeacherLastName",
                Students = new List<Student>()
            };
        }
    }
}
