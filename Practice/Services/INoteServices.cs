using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public interface INoteServices
    {
        IEnumerable<Note> GetAllNotes();

        Note FindNoteById(Guid id);

        void AddNote(Note note);

        void DeleteNote(Note note);
    }
}
