﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Models.Domain.Base;

namespace TimeTracker.Models.Domain
{
    public class Group : BaseDomainModel
    {
        [Required, MaxLength(200)]
        public String Name { get; set; }
    }
}
