using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.HomeWork
{
    public class Student : Person
    {
        public int StudentId { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Student: {FirstName} {LastName}, StudentId: {StudentId}");
        }

        public static Student RandomStudent()
        {
            // Генерация случайного студента
            return new Student
            {
                FirstName = "RandomStudent",
                LastName = "RandomName",
                StudentId = new Random().Next(1000, 9999)
            };
        }
    }
}
