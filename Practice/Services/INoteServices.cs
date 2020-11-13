using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public interface INoteServices
    {

        Note createNote(string subject, string content);

        List<Note> GetAllNotes();

        void AddNote(Note note);


    }
}
