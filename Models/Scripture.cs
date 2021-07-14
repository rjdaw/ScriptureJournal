using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ScriptureJournal.Models
{
    public class Scripture
    {
        public int ScriptureId { get; set; }

        [Required]
        public string Book { get; set; }

        [Range(1, 139), Required] //longest is D&C
        public int Chapter { get; set; }

        [Range(1, 177), Required] //longest is Psalm 119
        public int Verses { get; set; }

        [RegularExpression(@"^[ A-Za-z0-9_@./#&+-()]*$")]
        public string Notes { get; set; }
    }
}