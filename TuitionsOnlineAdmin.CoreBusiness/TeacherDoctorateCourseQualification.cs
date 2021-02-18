
using System;


using System.Collections.Generic;




#nullable disable




namespace TuitionsOnlineAdmin.CoreBusiness.Entities

{

    public partial class TeacherDoctorateCourseQualification

    {

        public TeacherDoctorateCourseQualification()

        {

            TeacherDoctorateCourseQualificationSubjects = new HashSet<TeacherDoctorateCourseQualificationSubject>();

        }




        public int TeacherDoctorateCourseQualificationId { get; set; }

        public int TeacherId { get; set; }

        public int DoctorateCourseId { get; set; }




        public virtual DoctorateCourse DoctorateCourse { get; set; }

        public virtual TeacherBasicInformation Teacher { get; set; }

        public virtual ICollection<TeacherDoctorateCourseQualificationSubject> TeacherDoctorateCourseQualificationSubjects { get; set; }

    }

}
