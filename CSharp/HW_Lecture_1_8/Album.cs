using System.Collections.Generic;

namespace HW_Lecture_1_8
{
    internal class Album
    {
        //Propertys
        public List<Song> Songs { get; } = new List<Song>();
        public string Title { get; }

        //Constructors
        public Album(string title = null)
        {
            Title = string.IsNullOrWhiteSpace(title) ? "Noname Album" : title;
        }
        public Album(List < Song> songs, string title = null)
            : this(title)
        {
            if(songs != null)
                Songs = songs;
        }

        //Methods
        public bool AddSong(Song song)
        {
            if (song == null) return false;

            Songs.Add(song);
            return true;
        }
        public bool AddSongRange(List<Song> songs)
        {
            if (songs == null || songs.Count == 0) return false;

            Songs.AddRange(songs);
            return true;
        }

        //Indexator
        public Song this[int index]
        {
            get
            {
                if (index < 0 || index >= Songs.Count) return null;
                return Songs[index];
            }
            set
            {
                if (index < 0 || index >= Songs.Count) return;
                Songs[index] = value;
            }

        }
    }
}