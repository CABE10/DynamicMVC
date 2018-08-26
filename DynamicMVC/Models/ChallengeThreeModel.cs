using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DynamicMVC.Models
{
    public class ChallengeThreeModel
    {
        [Display(Name = "Alias")]
        public string Alias { get; set; }
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Favorite Color")]
        public string FavoriteColor { get; set; }

        public bool IsSubmitted { get; set; }

    }
}
