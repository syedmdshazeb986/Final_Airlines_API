﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Airlines_API.Models
{
    public class Change
    {
        [Key]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string old_password { get; set; }
        [DataType(DataType.Password)]
        public string new_password { get; set; }
    }
}
