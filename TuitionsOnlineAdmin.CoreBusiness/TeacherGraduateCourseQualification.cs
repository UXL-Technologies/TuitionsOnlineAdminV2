﻿
using System;
using System.Collections.Generic;
#nullable disable
namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class TeacherGraduateCourseQualification
    {
        public int TeacherGraduateCourseQualificationId { get; set; }
        public int TeacherId { get; set; }
        public int GraduateCourseId { get; set; }
        public virtual GraduateCourse GraduateCourse { get; set; }
        public virtual TeacherBasicInformation Teacher { get; set; }


    }


}
