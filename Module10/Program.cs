using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.HomeWork
{
    

    class Program
    {
        static void Main()
        {
            // Создание массива объектов Person или их наследников
            var people = new List<Person>
        {
            new Person { FirstName = "Daniyar", LastName = "Khan" },
            Student.RandomStudent(),
            Student.RandomStudent(),
            Teacher.RandomTeacher(),
            new StudentWithAdvisor { FirstName = "Alice", LastName = "Milfs", StudentId = 123, Advisor = Teacher.RandomTeacher() }
        };

            // Вывод информации о каждом объекте в массиве
            foreach (var person in people)
            {
                person.Print();
            }

            // Перевод всех студентов на следующий курс
            foreach (var person in people)
            {
                if (person is Student student)
                {
                    Console.WriteLine($"Transferring {student.FirstName} {student.LastName} to the next course.");
                }
            }
        }
    }
}
