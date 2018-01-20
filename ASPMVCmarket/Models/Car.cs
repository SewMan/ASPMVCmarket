using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace ASPMVCmarket.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Vehicle Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "First Slogan")]
        public string Slogan1 { get; set; }
        [Required]
        [Display(Name = "Second Slogan")]
        public string Slogan2 { get; set; }
        [Required]
        [Display(Name = "Third Slogan")]
        public string Slogan3 { get; set; }
        [Required]
        [Display(Name = "Image path 1")]
        public string ImagePath1 { get; set; }
        [Required]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }
        [Required]
        [Display(Name = "Image path 2")]
        public string ImagePath2 { get; set; }
        [Required]
        [Display(Name = "Long Description")]
        public string LongDescription { get; set; }
        [Required]
        [Display(Name = "Image path 3")]
        public string ImagePath3 { get; set; }
        [Required]
        [Display(Name = "Transmission")]
        public string DetTransmission { get; set; }
        [Required]
        [Display(Name = "Wheelbase")]
        public string DetWheelbase { get; set; }
        [Required]
        [Display(Name = "Curb Weight")]
        public string DetCurbWeight { get; set; }
        [Required]
        [Display(Name = "Motor Type")]
        public string DetMotor { get; set; }
        [Required]
        [Display(Name = "Body Style")]
        public string DetBodyStyle { get; set; }
        [Required]
        [Display(Name = "Production Time")]
        public string DetProduction { get; set; }
        [Required]
        [Display(Name = "Vehicle Length")]
        public string DetLength { get; set; }
        [Required]
        [Display(Name = "Vehicle Width")]
        public string DetWidth { get; set; }
        [Required]
        [Display(Name = "Vehicle Height")]
        public string DetHeight { get; set; }
        [Required]
        [Display(Name = "Vehicle Price")]
        public string DetPrice { get; set; }
    }
}