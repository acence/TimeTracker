using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models.Domain.Base;

namespace TimeTracker.Models.Domain
{
    public class Entry :BaseDomainModel
    {
        [Required]
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public String Note { get; set; }

        public Int32 UserId { get; set; }
        public Int32 CategoryId { get; set; }

        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
    }
}
