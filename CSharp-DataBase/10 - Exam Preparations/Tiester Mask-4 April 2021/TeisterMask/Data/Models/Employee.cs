﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeisterMask.Data.Models
{
    public class Employee
    {
        public Employee()
        {
            EmployeesTasks = new HashSet<EmployeeTask>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)] 
        public string Username { get; set; } // min length 3 , Should contain only lower or upper case letters and/or digits. (required)

        [Required]
        public string Email { get; set; } //text(required). Validate it! There is attribute for this job.

        [Required]
        public string Phone { get; set; }
        //text.Consists only of three groups(separated by '-'), the first two consist of three digits and the last one - of 4 digits. (required)
        public ICollection<EmployeeTask> EmployeesTasks { get; set; }

        

    }
}
