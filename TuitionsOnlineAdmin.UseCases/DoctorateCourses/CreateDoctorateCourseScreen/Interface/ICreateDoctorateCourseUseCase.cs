using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen.Interface
{
   public interface ICreateDoctorateCourseUseCase
    {
        void CreateDoctorateCourse(DoctorateCourse doctorateCourse);
    }
}
