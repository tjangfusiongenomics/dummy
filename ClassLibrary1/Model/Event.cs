using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Model
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Display(Name = "Date & From time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
        public DateTime FromDate { get; set; }

        [Display(Name = "Date & To time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]

        [DataType(DataType.DateTime)]

        public DateTime ToDate { get; set; }


        [Display(Name = "Activity")]
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }

        [Display(Name = "Creator")]
        public string Id { get; set; }


    }
}
