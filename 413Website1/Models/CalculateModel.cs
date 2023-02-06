﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _413Website1.Models
{
    public class CalculateModel
    {
        // Sets field to required input
        [Required]
        // Input must be within 1 and 100
        [Range(0, 100)]
        // Makes Getter and Setter for Assignment variable
        public byte Assignment { get; set; }
        [Required]
        [Range(0, 100)]

        public byte Pg { get; set; }
        [Required]
        [Range(0, 100)]
        public byte Quiz { get; set; }
        [Required]
        [Range(0, 100)]
        public byte Midterm { get; set; }
        [Required]
        [Range(0, 100)]
        public byte Final { get; set; }
        [Required]
        [Range(0, 100)]
        public byte Intex { get; set; }
    }
}
