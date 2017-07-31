using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviews.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public double Days { get; set; } /* number of days since review date*/

        [Display(Name = "Comments")]
        public string Content { get; set; }

        [Display(Name = "Date Reviewed")]
        [Required(ErrorMessage = "Date Required")]
        public DateTime ReviewDate { get; set; }

        [Required(ErrorMessage = "Stars Required")]
        [Range(0, 5, ErrorMessage = "Stars must be between 0 and 5")]
        public int Stars { get; set; }
        public string PicUrl { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        [ForeignKey("Reviewer")]
        public int ReviewerID { get; set; }
        public virtual Reviewer Reviewer { get; set; }

        [ForeignKey("Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

        public double DaysReview()
        {
            TimeSpan difference = DateTime.Now - ReviewDate;
            Days = difference.TotalDays;
            return Days;
        }
    }
}