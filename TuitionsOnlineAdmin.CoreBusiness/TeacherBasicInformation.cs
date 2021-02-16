//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the Class for TeacherBasicInformation ;





//Author: GJ, TP, VM, SN
//Date: 16/02/2021
//commenting the below code since the entity teacher basic information is migrated from Teacher self Administration solution

//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Text;

//namespace TuitionsOnlineAdmin.CoreBusiness
//{
//    public class TeacherBasicInformation
//    {
//        //property to store TeacherId .
//        [Key]
//        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        public int TeacherId { get; set; }

//        //property to store TeacherFullName 
//        [Required(ErrorMessage = "Please enter teacher’s full name")]
//        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
//        [MaxLength(255, ErrorMessage = "The teacher’s full name you have entered is too long. Please restrict the name to less than 255 alphabets.")]
//        [RegularExpression(@"^[A-Za-z\s]{1,}[\.]{0,}[A-Za-z.\s]{0,}", ErrorMessage = "Please use only alphabets in the teacher’s full name.")]
//        public string TeacherFullName { get; set; }

//        //property to store Active status 
//        public bool Active { get; set; } = true;

//        //property to store EmailAddress 
//        [Required(ErrorMessage = "Please enter the email address.")]
//        [DataType(DataType.EmailAddress)]
//        [EmailAddress(ErrorMessage = "This does not seem like an email address.Please check and enter again.")]
//        public string EmailAddress { get; set; }

//        //property to store ContactTeleNumber 
//        [Required(ErrorMessage = "Please enter the contact number")]
//        [Range(10, 10, ErrorMessage = "Please enter a contact number of minimum 10 characters.")]
//        public int ContactTeleNumber { get; set; }

//        //property to store TeacherPhotographUrl 
//        [Url(ErrorMessage = "This does not seem like an url . Please check and enter again.")]
//        public string TeacherPhotographUrl { get; set; }

//        //property to store PreferredLanguage 
//        [Required(ErrorMessage = "Please enter the language the teacher prefers to teach in.")]
//        [MaxLength(100, ErrorMessage = "The preferred language you have entered is too long. Please restrict the name to less than 100 alphabets.")]
//        public string PreferredLanguage { get; set; }

//        //property to store AlternateLanguage 
//        [MaxLength(100, ErrorMessage = "The alternate language you have entered is too long. Please restrict the name to less than 100 alphabets.")]
//        public string AlternateLanguage { get; set; }

//        //property to store ExperienceInYears
//        [Required(ErrorMessage = "Please enter the number of years of experience the teacher has in teaching")]
//        [Range(2, 2, ErrorMessage = "Please enter the number of years of experience that is not more than 2 digits.")]
//        public int ExperienceInYears { get; set; }
//    }
//}
