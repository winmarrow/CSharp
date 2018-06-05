using System;
using System.Collections.Generic;

namespace HW_Lecture_1_9
{
    internal class Student
    {
        private readonly List<Mark> _marks = new List<Mark>();

        public string FirstName;
        public string LastName;
        public DateTime DoB;

        public void AddMark(Mark mark)
        {
            if (IsMarkValid(mark) && !_marks.Contains(mark))
                _marks.Add(mark);
        }

        private bool IsMarkValid(Mark mark)
        {
            return !string.IsNullOrWhiteSpace(mark.LectureName)
                   && mark.MarkNumber > 0 && mark.MarkNumber <= 10
                   && mark.Date != default(DateTime);
        }

        public override bool Equals(object obj)
        {
            return obj is Student student
                   && student.FirstName == this.FirstName
                   && student.LastName == this.LastName
                   && student.DoB == this.DoB;
        }

        public override string ToString()
        {
            _marks.Sort();

            double minMark = _marks?.Count> 0 ? _marks[0].MarkNumber : 0d;
            double maxMark = _marks?.Count > 0 ? _marks[_marks.Count-1].MarkNumber:0d;
            double avgMark = CalculateAvgMark();

            return $"Student - {FirstName} {LastName}, marks:{minMark}/{maxMark}/{avgMark}";
        }

        private double CalculateAvgMark()
        {
            if (_marks.Count == 0) return 0d;

            if (_marks.Count == 1) return _marks[0].MarkNumber;

            double sum = 0d;
            foreach (Mark singleMark in _marks)
                sum += singleMark.MarkNumber;

            return sum / _marks.Count;
        }
    }
}