using System;
using System.Collections.Generic;
using System.Text;

namespace Practise2.Models
{
    class Student
    {
        private static int _id = 0;
        public int Id { get; }
        public string FullName { get; set; }
        public int Point { get; set; }

        private Student()
        {
            _id++;
            Id = _id;
        }

        public Student(string fullName, int point) : this()
        {
            FullName = fullName;
            Point = point;
        }
        public void StudentInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {FullName}, Poimt:{Point}");
        }
    }
}
