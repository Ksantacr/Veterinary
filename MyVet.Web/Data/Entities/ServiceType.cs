﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyVet.Web.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field {0} is mandatory")]
        [MaxLength(50, ErrorMessage = "The {0} field cannot have more than {1} characters.")]
        [Display(Name = "Service Type")]
        public string Name { get; set; }
        public ICollection<History> Histories { get; set; }
    }
}
