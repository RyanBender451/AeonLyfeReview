using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Aeonlyfe.Models
{
    public class Review
    {
        //This sets up the db vars and gives the display names for them
        [Key]
        public int ReviewID { get; set; }
        [Display(Name = "How many starts will you give this place")]
        public int ReviewScore { get; set; }
        [Display(Name = "What do people think of this review")]
        public int ReviewReview { get; set; }
        [Display(Name = "Title")]
        public string ReviewTitle { get; set; }
        [Display(Name = "Author")]
        public string ReviewAuthor { get; set; }
        [Display(Name = "Comment")]
        public string ReviewContent { get; set; }
        [Display(Name = "Date")]
        public DateTime ReviewDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}