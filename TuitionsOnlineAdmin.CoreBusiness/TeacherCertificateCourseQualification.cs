
using System;




using System.Collections.Generic;







#nullable disable







namespace TuitionsOnlineAdmin.CoreBusiness.Entities


{


    public partial class TeacherCertificateCourseQualification


    {


        public TeacherCertificateCourseQualification()


        {


            TeacherCertificateCourseQualificationSubjects = new HashSet<TeacherCertificateCourseQualificationSubject>();


        }







        public int TeacherCertificateCourseQualificationId { get; set; }


        public int TeacherId { get; set; }


        public int CertificateCourseId { get; set; }







        public virtual CertificateCourse CertificateCourse { get; set; }


        public virtual TeacherBasicInformation Teacher { get; set; }


        public virtual ICollection<TeacherCertificateCourseQualificationSubject> TeacherCertificateCourseQualificationSubjects { get; set; }


    }


}
