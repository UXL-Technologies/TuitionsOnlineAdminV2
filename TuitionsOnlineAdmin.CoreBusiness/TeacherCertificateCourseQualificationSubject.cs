
using System;




using System.Collections.Generic;







#nullable disable







namespace TuitionsOnlineAdmin.CoreBusiness.Entities


{


    public partial class TeacherCertificateCourseQualificationSubject


    {


        public int TeacherId { get; set; }


        public int CertificateCourseId { get; set; }


        public int SubjectId { get; set; }







        public virtual Subject Subject { get; set; }


        public virtual TeacherCertificateCourse_Qualification TeacherCertificateCourseQualification { get; set; }


    }


}
