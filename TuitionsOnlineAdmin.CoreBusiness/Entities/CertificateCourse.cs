using System;
using System.Collections.Generic;

#nullable disable

namespace TuitionsOnlineAdmin.CoreBusiness.Entities
{
    public partial class CertificateCourse
    {
        public CertificateCourse()
        {
            TeacherCertificateCourseQualifications = new HashSet<TeacherCertificateCourseQualification>();
        }

        public int CertificateCourseId { get; set; }
        public string CertificateCourseName { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<TeacherCertificateCourseQualification> TeacherCertificateCourseQualifications { get; set; }
    }
}
