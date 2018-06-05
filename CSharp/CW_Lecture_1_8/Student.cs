using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_Lecture_1_8
{
    public class Student
    {
        private string _fullName;
        public string GetFullName()
        {
            return _fullName ?? String.Empty;
        }
        public void SetFullName(string fullName)
        {
            if(string.IsNullOrWhiteSpace(fullName)) return;
            _fullName = fullName;
        }

        private int _age;

        public int Age
        {
            get { return _age <18?  18: _age ;}
            set { if(value > 18 && value < 50) _age = value;}
        }


        public string GroupId { get; set; }


        public List<int> Marks;

        public double AvgMark
        {
            get
            {
                if (Marks != null || Marks.Count == 0) return 0.0;

                double sum = 0.0;

                foreach (var t in Marks)
                {
                    sum += t;
                }

                return sum / Marks.Count;
            }
        }
    }
}
