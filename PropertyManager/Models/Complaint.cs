﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyManager.Models
{
    public class Complaint
    {
        [Key]
        public int Id { get; set; }
        public string Issue { get; set; }
    }
}
