
using System;




using System.Collections.Generic;







#nullable disable







namespace TuitionsOnlineAdmin.CoreBusiness.Entities


{


    public partial class TeacherGraduateCourseQualificationSubject


    {


        public int TeacherId { get; set; }


        public int GraduateCourseId { get; set; }


        public int SubjectId { get; set; }







        public virtual Subject Subject { get; set; }


        public virtual TeacherGraduateCourseQualification TeacherGraduateCourseQualification { get; set; }


    }


}
