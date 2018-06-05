using System;
using System.Collections.Generic;

namespace HW_Lecture_1_9
{
    internal class StudentGroup
    {
        //Collection
        private readonly List<Student> _students = new List<Student>();

        //Add
        public void Add(Student student)
        {
            if(student!= null && IsStudentValid(student))
                _students.Add(student);
        }

        //Remove
        public void Remove(Student student)
        {
            if (student != null && IsStudentValid(student) && _students.Contains(student))
                _students.Add(student);
        }
        public void RemoveAt(int index)
        {
            if(index> 0 && index < _students.Count)
                _students.RemoveAt(index);
        }

        private bool IsStudentValid(Student student)
        {
            return !string.IsNullOrWhiteSpace(student.FirstName)
                   && !string.IsNullOrWhiteSpace(student.LastName)
                   && student.DoB != default(DateTime);
        }

        //Indexator
        public Student this[int index]
        {
            get
            {
                if (index > 0 && index < _students.Count)
                    return _students[index];

                return null;
            }
        }
    }
}