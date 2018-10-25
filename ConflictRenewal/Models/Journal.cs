﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConflictRenewal.Models
{
    public class Journal
    {
        public int Id { get; set; }

        [Display(Name = "Conflict Date")]
        [DataType(DataType.Date)]
        public DateTime JournalDate { get; set; }

        [Display(Name = "Journal Entry")]
        [DataType(DataType.MultilineText)]
        public string JournalContent { get; set; }

        public int ConflictId { get; set; }
        public Conflict Conflict { get; set; }
    }
}