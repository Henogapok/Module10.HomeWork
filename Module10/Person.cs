using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Module10.HomeWork
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void Print()
        {
            Console.WriteLine($"Person: {FirstName} {LastName}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Person otherPerson)
            {
                return FirstName == otherPerson.FirstName && LastName == otherPerson.LastName;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName);
        }

        public static bool operator ==(Person person1, Person person2)
        {
            return person1?.Equals(person2) ?? ReferenceEquals(person2, null);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}
