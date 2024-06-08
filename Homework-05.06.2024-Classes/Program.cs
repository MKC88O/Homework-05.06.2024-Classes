using System.Collections.Generic;

namespace Homework_05._06._2024_Classes
{
    class Student
    {
        private string? name;
        private string? lastName;
        private string? patronymic;
        private DateOnly dateOfBirth;
        private string? homeAdres;
        private string? phoneNumber;
        private readonly List<int> tests;
        private readonly List<int> courseWorks;
        private readonly List<int> exams;

        public Student() : this("Ivan", "Ivanovich", "Ivanov", new DateOnly(2000, 01, 01), "str.Bolharskaya, 87", "+38(068)1234567") {}

        public Student(string? name, string? patronymic , string? lastName) : 
            this(name, lastName, patronymic, new DateOnly(2000, 01, 01), "Home Adres", "Phone Number"){}

        public Student(string? name, string? lastName, DateOnly dateOfBirth, string? phoneNumber) :
            this(name, "Patronymic", lastName, dateOfBirth, "Home Adres", phoneNumber){}

        public Student(string? name, string? patronymic, string? lastName, DateOnly dateOfBirth, string? homeAdres, string? phoneNumber)
        {
            SetName(name);
            SetPatronymic(patronymic);
            SetlastName(lastName);
            SetDateOfBirth(dateOfBirth);
            SetHomeAdres(homeAdres);
            SetPhoneNumber(phoneNumber);
            tests = new List<int>();
            courseWorks = new List<int>();
            exams = new List<int>();
        }
    
        public void SetName(string? name)
        {
            this.name = name; 
        }
        public void SetlastName(string? lastName)
        {
            this.lastName = lastName;
        }
        public void SetPatronymic(string? patronymic)
        {
            this.patronymic = patronymic;
        }
        public void SetDateOfBirth(DateOnly dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
        }
        public void SetHomeAdres(string? homeAdres)
        {
            this.homeAdres = homeAdres;
        }
        public void SetPhoneNumber(string? phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public string? GetName()
        {
            return name;
        }
        public string? GetLastName()
        {
            return lastName;
        }
        public string? GetPatronymic()
        {
            return patronymic;
        }
        public DateOnly GetDateOfBirth()
        {
            return dateOfBirth;
        }
        public string? GetHomeAdres()
        {
            return homeAdres;
        }
        public string? GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void Print()
        {
            Console.WriteLine("\tStudent Info: \n");
            Console.WriteLine("Name: \t\t" + name);
            Console.WriteLine("Last name: \t" + lastName);
            Console.WriteLine("Patronymic: \t" + patronymic);
            Console.WriteLine("Date of birth: \t" + dateOfBirth);
            Console.WriteLine("Home adres: \t" + homeAdres);
            Console.WriteLine("Phone number: \t" + phoneNumber);
            Console.Write("Tests: \t\t");
            foreach (var test in tests)
            {
                Console.Write(test + " ");
            }
            Console.Write("Average: " + tests.Average());
            Console.WriteLine();

            Console.Write("Course works: \t");
            foreach (var courseWork in courseWorks)
            {
                Console.Write(courseWork + " ");
            }
            Console.Write("Average: " + tests.Average());
            Console.WriteLine();

            Console.Write("Exams: \t\t");
            foreach (var exam in exams)
            {
                Console.Write(exam + " ");
            }
            Console.Write("Average: " + tests.Average());
            Console.WriteLine();
        }

        public void AddTestsRatings(int rating)
        {
            tests.Add(rating);
        }

        public void AddCourseWorksRatings(int rating)
        {
            courseWorks.Add(rating);
        }

        public void AddExamsRatings(int rating)
        {
            exams.Add(rating);
        }

        public void RemoveTestsRatings(int rating)
        {
            tests.Remove(rating);
        }

        public void RemoveCourseWorksRatings(int rating)
        {
            courseWorks.Remove(rating);
        }

        public void RemoveExamsRatings(int rating)
        {
            exams.Remove(rating);
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.AddTestsRatings(10);
            student.AddTestsRatings(11);
            student.AddTestsRatings(12);
            student.AddTestsRatings(2);

            student.AddCourseWorksRatings(12);
            student.AddCourseWorksRatings(11);
            student.AddCourseWorksRatings(10);
            student.AddCourseWorksRatings(2);

            student.AddExamsRatings(12); 
            student.AddExamsRatings(12);
            student.AddExamsRatings(10);
            student.AddExamsRatings(2);

            student.Print();
            Console.WriteLine();

            student.RemoveTestsRatings(2);
            student.RemoveCourseWorksRatings(2);
            student.RemoveExamsRatings(2);

            student.Print();
        }
    }
}
