using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class TeacherAuthenticationDetails
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeacherId { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string TeacherObjectId { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string TeacherName { get; set; }
        [Column(TypeName = "varchar(150)")]
        public string TeacherEmailAddress { get; set; }
    }
}
