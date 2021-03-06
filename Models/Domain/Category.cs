﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models.Domain.Base;

namespace TimeTracker.Models.Domain
{
    public class Category: BaseDomainModel
    {
        [Required]
        public String Name { get; set; }
        public Int32 TextColor { get; set; }
        public Int32 BackgroundColor { get; set; }

        public virtual ICollection<Entry> Entries { get; set; }
    }
}
