//Authors: SA, BM, SM
//Date:12-Jan-2021
//Aim: defining the entity for TeacherVideo

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
   public class TeacherVideo
    {
        //property to store TeacherVideoId 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid TeacherVideoId { get; set; }

        //property to store VideoURL 
        [Url(ErrorMessage = "This does not seem like an url . Please check and enter again.")]
        public string VideoURL { get; set; }

        //property to store Active status 
        public bool Active { get; set; } = true;
    }
}
