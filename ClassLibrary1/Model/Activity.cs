﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public class Activity
    {
        [Key]
        [Display(Name = "Activity")]
        public int ActivityId { get; set; }

        [Display(Name = "Activity")]
        public string ActivityDec { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date Created")]
        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public List<Event> Event { get; set; }
    }
}
