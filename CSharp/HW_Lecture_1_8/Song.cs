﻿using System;

namespace HW_Lecture_1_8
{
    internal class Song
    {
        //Constants
        private const int MinSongDuration = 500; // ms
        private const int MaxSongDuration = 2500; // ms

        private const int MinSongFrequency = 50; // Hz
        private const int MaxSongFrequency = 2000; // Hz

        private static readonly Random Rand = new Random(DateTime.Now.Second);

        //Propertys
        public object Band { get; }
        public object Title { get; }

        public int Duration { get; }
        public int Frequency { get; }


        public void Play()
        {
            Console.Beep(Frequency, Duration);
        }

        //Constructors
        public Song(string band = null, string title = null)
        {
            Duration = Rand.Next(MinSongDuration, MaxSongDuration);
            Frequency = Rand.Next(MinSongFrequency, MaxSongFrequency);

            Band =  string.IsNullOrWhiteSpace(band) ? "Noname Band" : band;
            Title = string.IsNullOrWhiteSpace(title) ? "Noname Song" : title;
        }
        public Song(string band, string title, int duration, int frequency)
            : this(band, title)
        {
            Duration = duration;
            Frequency = frequency;
        }
    }
}