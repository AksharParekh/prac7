using System;
using System.ComponentModel.DataAnnotations;

namespace prac7.Models
{
    public class Feedback
    {
        [Required(ErrorMessage = "Enrollment Number is required")]
        [Display(Name = "Enrollment No")]
        public string EnrollmentNo { get; set; }

        [Required(ErrorMessage = "Student Name is required")]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Subject is required")]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        [Display(Name = "Rating")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "Comments must be between 5 and 200 characters")]
        [Display(Name = "Comments")]
        public string Comments { get; set; }
    }
}