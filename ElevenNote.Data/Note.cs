using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Note
    {
        [Key]
        public int NoteId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Display(Name = "Note Title")]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Note Content")]
        [Required]
        public string Content { get; set; }

        [Display(Name = "Date and Time Created")]
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        [Display(Name = "Date and Time Last Modified")] 
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
