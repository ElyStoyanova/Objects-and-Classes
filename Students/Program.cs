using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string inputCommand = Console.ReadLine();

            while (inputCommand!="end")
            {
                string[] tokans = inputCommand.Split();
                Student student = new Student(tokans[0], tokans[1], int.Parse(tokans[2]), tokans[3]);
                students.Add(student);
                inputCommand = Console.ReadLine();
            }
            string cityName = Console.ReadLine();

            foreach (Student  student in students)
            {
                if (student.HomeTown==cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LasttName} is {student.Age} years old.");
                }
            }
        }
    }
    class Student
    {
        public Student(string firsName,string lastName,int age,string homeTown)
        {
            this.FirstName = firsName;
            this.LasttName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
              
        }
        public string  FirstName { get; set; }
        public string  LasttName { get; set; }
        public int Age { get; set; }
        public string  HomeTown { get; set; }
    }
}
