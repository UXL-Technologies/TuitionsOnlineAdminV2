using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.TeacherVideos.CreateTeacherVideoScreen.Interfaces
{
    public interface ICreateTeacherVideoUseCase
    {
        void CreateTeacherVideo(TeacherVideo teacherVideo);
    }
}
