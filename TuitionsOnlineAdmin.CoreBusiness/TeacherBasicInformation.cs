//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Class for TeacherBasicInformation ;


//Author: GJ, TP, VM, SN
//Date: 16/02/2021
//commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class TeacherBasicInformation
    {
        [Key]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        [ForeignKey("TeacherAuthenticationDetails")]
        public int TeacherId { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Teacher_Name { get; set; }

        [Required(ErrorMessage = "Please enter a correct phone number")]
        [Range(1000000000, 999999999999999, ErrorMessage = "Please enter a valid phone number")]
        public long Contact_Telephone_Number { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Column(TypeName = "varchar(150)")]
        public string Email_Address { get; set; }

        [Required(ErrorMessage = "Please enter the city you are now located at")]
        [Column(TypeName = "varchar(150)")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the pincode of your location")]
        [Range(100000, 999999, ErrorMessage = "Please enter a valid pincode")]
        public int Pincode { get; set; }
        [Required]
        public bool Active { get; set; }
        [Required(ErrorMessage = "Please describe your qualifications in as much detail as possible")]
        public string Qualifications { get; set; }
        [Required(ErrorMessage = "Please let us know details about the subjects and students you want to teach")]
        public string Teaching_Interests { get; set; }
        [Required(ErrorMessage = "Please highlight the value you bring to your students")]
        public string Selling_Point { get; set; }
        [Required(ErrorMessage = "Please explain your pricing model")]
        public string Pricing_Structure { get; set; }
        [Required(ErrorMessage = "Please describe your teaching experience")]
        public string Teaching_Experience { get; set; }
        [Required(ErrorMessage = "Please mention details about your schedule for tuitions")]
        public string Schedule { get; set; }

        //add foreign key reference
        public virtual TeacherAuthenticationDetails TeacherAuthenticationDetails { get; set; }
    }
}
