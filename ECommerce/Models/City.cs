using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ECommerce.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }

        [Required(ErrorMessage = "the field {0} is required")]
        [MaxLength(50, ErrorMessage = "the field {0} must be at least {1} characters length")]
        [Display(Name = "City")]
        public string Name { get; set; }

        [Required(ErrorMessage = "the field {0} is required")]
        public int DeparmentId { get; set; }

        public virtual Deparment Deparment { get; set; }
    }
}