﻿using System.ComponentModel.DataAnnotations;

namespace UNITINS_DoisIrmaos.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, insert a name")]
        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Minimum of 2 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, insert a description")]
        [Display(Name = "Description")]
        [StringLength(280)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please, insert a price value")]
        [Display(Name = "Price")]
        public float Price { get; set; }

        [Display(Name = "Features")]
        public ICollection<CategoryFeature> Features { get; set;}

        public Category() { 
            Features = new List<CategoryFeature>();
        }
    }
}
