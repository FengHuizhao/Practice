using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public class NoteServices : INoteServices
    {
        private readonly List<Note> _notes;

        public NoteServices()
        {
            _notes = new List<Note>();
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _notes;
        }

        public Note FindNoteById(Guid id)
        {
            var note = _notes.Find(n => n.Id == id);
            return note;
        }

        public void AddNote(Note note)
        {
            if (note != null)
            {
                _notes.Add(note);
            }   
        }

        public void DeleteNote(Note note)
        {
            _notes.Remove(note);
        }
    }
}
