using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PostGraduateCourses.CreatePostGraduateCourseScreen.Interface
{
    public interface ICreatePostGraduateCourseUseCase
    {
        void CreatePostGraduateCourse(PostGraduateCourse postGraduateCourse);
    }
}
