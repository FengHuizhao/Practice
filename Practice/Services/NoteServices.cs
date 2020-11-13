using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public class NoteServices : INoteServices
    {
        private readonly List<Note> notes;

        public NoteServices()
        {
            notes = new List<Note>();
        }

        public Note createNote(string subject, string content)
        {
            Note note = new Note(subject, content);
            return note;
        }

        public List<Note> GetAllNotes()
        {
            return notes;
        }

        public void AddNote(Note note)
        {
            if (note != null)
            {
                notes.Add(note);
            }
            
        }

    }
}
