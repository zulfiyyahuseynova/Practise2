using System;
using System.Collections.Generic;
using System.Text;

namespace Practise2.Models
{
    class Group
    {
        public string GroupNo { get; set; }
        private int _studentLimit;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                }
            }
        }
        private Student[] _students;

        //public Group(string groupNo, int studentLimit)
        //{
        //    GroupNo = groupNo;
        //    StudentLimit = studentLimit;
        //}

        public bool CheckGroupNo(string groupNo)
        {
            bool isUpper1 = false;
            bool isUpper2 = false;
            bool isDigit1 = false;
            bool isDigit2 = false;
            bool isDigit3 = false;
            if (groupNo.Length == 5)
            {
                if (char.IsUpper(groupNo[0])) isUpper1 = true;
                else return false;
                if (char.IsUpper(groupNo[1])) isUpper2 = true;
                else return false;
                if (char.IsDigit(groupNo[2])) isDigit1 = true;
                else return false;
                if (char.IsDigit(groupNo[3])) isDigit2 = true;
                else return false;
                if (char.IsDigit(groupNo[4])) isDigit3 = true;
                else return false;

                if (isUpper1 && isUpper2 && isDigit1 && isDigit2 && isDigit3)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddStudent(Student student)
        {
            if (_students.Length < StudentLimit)
            {
                Array.Resize(ref _students, _students.Length);
                _students[_students.Length - 1] = student;
            }
            else
            {
                Console.WriteLine("Group is full");
            }
        }

        public void GetStudent(int? studentId)
        {
            if (studentId != null)
            {
                foreach (Student student in _students)
                {
                    if (student.Id == studentId)
                    {
                        Console.WriteLine(student);
                    }
                }
            }
            else
            {
                Console.WriteLine("Student not found");
            }

        }

        public void GetAllStudents()
        {
            foreach (var item in _students)
            {
                Console.WriteLine(item);
            }
        }

    }
}
