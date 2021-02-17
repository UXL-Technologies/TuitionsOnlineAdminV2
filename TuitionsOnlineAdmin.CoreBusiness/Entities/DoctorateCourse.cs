using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class DoctorateCourse
    {
        public DoctorateCourse()
        {
            TeacherDoctorateCourseQualifications = new HashSet<TeacherDoctorateCourseQualification>();
        }

        public int DoctorateCourseId { get; set; }
        public string DoctorateCourseName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TeacherDoctorateCourseQualification> TeacherDoctorateCourseQualifications { get; set; }
    }
}
