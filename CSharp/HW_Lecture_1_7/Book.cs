using System;

namespace HW_Lecture_1_7
{
    public enum BookGenge
    {
        Tragedy,
        TragicComedy,
        Fantasy,
        Mythology,
        Adventure,
        Mystery

    }

    public class Book
    {
        public string Title;
        public BookGenge Genre;
        public Author Author;

        public bool IsAvailable;
    }
}