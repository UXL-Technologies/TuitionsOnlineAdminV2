using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class TeacherDoctorateCourseQualificationSubject
    {
        public int TeacherId { get; set; }
        public int DoctorateCourseId { get; set; }
        public int SubjectId { get; set; }

        public virtual Subject Subject { get; set; }
        public virtual TeacherDoctorateCourseQualification TeacherDoctorateCourseQualification { get; set; }
    }
}
