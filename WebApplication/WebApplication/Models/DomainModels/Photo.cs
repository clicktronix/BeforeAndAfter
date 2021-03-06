﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models.DomainModels
{
    public class Photo
    {
        public int PhotoId { get; set; }

        [Display(Name = "Описание")]
        [Required]
        public string Description { get; set; }

        [Display(Name = "Image Path")]
        public string ImagePath { get; set; }

        [Display(Name = "Thumb Path")]
        public string ThumbPath { get; set; }

        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }

        public ApplicationUser Sender { set; get; }
    }
}