using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviews.Models
{
    public class Reviewer
    {
        [Key]
        public int ReviewerID { get; set; }

        [Display(Name = "Reviewer")]
        public string ReviewerName { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        [ForeignKey("ReviewerLevel")]
        public int ReviewerLevelID { get; set; }
        public virtual ReviewerLevel ReviewerLevel { get; set; }
    }
}