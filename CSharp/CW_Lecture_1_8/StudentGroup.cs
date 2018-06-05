using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_1_8
{
    public class StudentGroup
    {
        private List<Student> _students;

        public StudentGroup()
        {
            _students = new List<Student>();
        }

        public void Add(Student student)
        {
            if(student != null) _students.Add(student);
        }

        public bool Contains(Student student)
        {
            return _students.Contains(student);
        }

        public Student GetAt(int index)
        {
            return _students[index];
        }


        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= _students.Count) return null;
                return _students[index];
            }

            set
            {
                if(index < 0 || index >= _students.Count) return;
                _students[index] = value;
            }
            
        }
    }
}
