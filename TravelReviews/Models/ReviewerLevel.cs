using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReviews.Models
{
    public class ReviewerLevel
    {
        [Key]
        public int ReviewerLevelID { get; set; }
        public string Level { get; set; }

        public virtual ICollection<Reviewer> Reviewers { get; set; }
    }
}