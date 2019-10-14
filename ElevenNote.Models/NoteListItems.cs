using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteListItems
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        [Display(Name="Created")]
        [UIHint("Starred")]
        public bool IsStarred { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }

}
