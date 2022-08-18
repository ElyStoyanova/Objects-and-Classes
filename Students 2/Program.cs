using System;
using System.Collections.Generic;
using System.Linq;

namespace Students_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < countOfStudents; i++)
            {
                string []tokans = Console.ReadLine().Split();
                Student student = new Student
                {
                    FirstName=tokans[0],
                    LastName=tokans[1],
                    Grade=double.Parse(tokans[2])
                };
                students.Add(student);
            }
            foreach (Student student in students.OrderByDescending(g=>g.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
