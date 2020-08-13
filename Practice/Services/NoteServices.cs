using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Practice.Models;

namespace Practice.Services
{
    public class NoteServices
    {
        public Note createNote(string subject, string content)
        {
            Note note = new Note(subject, content);
            return note;
        }
    }
}
