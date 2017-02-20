using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class Deparment
    {
        [Key]
        public int DeparmentId { get; set; }

        [Required(ErrorMessage = "the field {0} is required")]
        [MaxLength(50, ErrorMessage = "the field {0} must be at least {1} characters length")]
        [Display(Name = "Deparment")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}