using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.Models
{
    public class Note
    {
        public Note(string subject, string content)
        {
            this.subject = subject;
            this.content = content;
        }

        public string subject { get; set; }

        public string content { get; set; }
    }
}
