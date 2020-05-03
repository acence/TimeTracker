using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Models.Domain.Base
{
    public class BaseDomainModel
    {
        [Key]
        public Int32 Id { get; set; }
    }
}
