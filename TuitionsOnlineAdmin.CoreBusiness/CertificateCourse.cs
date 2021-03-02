//Authors: Shravan A, Bhavya MU, Sneha M , Karan Kumar , Bhargavi S Adiga
//Date:08-Jan-2021
//Aim: defining the entity for certificate course

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class CertificateCourse
    {
        //property to store CertificateCourseId 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CertificateCourseId { get; set; }

        //property to store CertificateCourseName
        [Column(TypeName = "varchar(150)")]
        [Required(ErrorMessage = "Please enter the name of the certificate course.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [MaxLength(150, ErrorMessage = "The certificate course name you have entered is too long. Please restrict the name to less than 150 alphabets.")]
        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the name of the certificate course.")]
        public string CertificateCourseName { get; set; }

        //property to store Active status
        [Required]
        public bool Active { get; set; } = true;
    }
}
