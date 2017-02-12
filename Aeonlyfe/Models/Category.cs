using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aeonlyfe.Models
{
    public class Category
    {
        //sets up the vars and gets the display name, it also adds this to the collection
        public int Id { get; set; }
        [Display(Name = "Religion")]
        public string Place { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}