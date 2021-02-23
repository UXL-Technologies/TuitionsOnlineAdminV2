using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class TeacherGraduateCourse_QualificationWithForeignKey:TeacherGraduateCourse_Qualification
    {
        [ForeignKey("TeacherId")]
        public virtual TeacherBasicInformation TeacherBasicInformation { get; set; }
    }
}
