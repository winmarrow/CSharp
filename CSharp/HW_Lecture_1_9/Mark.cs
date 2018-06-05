using System;

namespace HW_Lecture_1_9
{
    internal struct Mark : IComparable
    {
        public string LectureName;
        public DateTime Date;
        public int MarkNumber;

        public int CompareTo(object obj)
        {
            Mark mark = (Mark) obj;
            return mark.MarkNumber - this.MarkNumber;
        }
    }
}
