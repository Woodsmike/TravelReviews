using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviews.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Display(Name = "Location")]
        public string LocationName { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}