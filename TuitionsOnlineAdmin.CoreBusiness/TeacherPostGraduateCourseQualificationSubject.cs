
using System;




using System.Collections.Generic;







#nullable disable







namespace TuitionsOnlineAdmin.CoreBusiness.Entities


{


    public partial class TeacherPostGraduateCourseQualificationSubject


    {


        public int TeacherId { get; set; }


        public int PostGraduateId { get; set; }


        public int SubjectId { get; set; }







        public virtual Subject Subject { get; set; }


        public virtual TeacherPostGraduateCourseQualification TeacherPostGraduateCourseQualification { get; set; }


    }


}
