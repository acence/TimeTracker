using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models.Domain.Base;

namespace TimeTracker.Models.Domain
{
    public class User : BaseDomainModel
    {
        [Required, MinLength(6), MaxLength(20)]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
    }
}
