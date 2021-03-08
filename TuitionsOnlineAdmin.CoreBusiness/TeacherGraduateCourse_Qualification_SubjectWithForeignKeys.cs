using System;
using System.Collections.Generic;
using System.Text;

namespace TuitionsOnlineAdmin.CoreBusiness
{
    public class TeacherGraduateCourse_Qualification_SubjectWithForeignKeys : TeacherGraduateCourse_Qualification_Subject
    {
        public string TeacherName { get; set; }

        public string GraduateCourseName { get; set; }

        public string SubjectName { get; set; }
    }
}
