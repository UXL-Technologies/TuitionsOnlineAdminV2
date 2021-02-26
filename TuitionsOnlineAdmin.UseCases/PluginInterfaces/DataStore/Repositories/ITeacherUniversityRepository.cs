//Authors: SA, BM, SM , BA, KK
//Date:26-Feb-2021
//Aim: defining the pluginInterface  Repository  for TeacherUniversity;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
   public interface ITeacherUniversityRepository
    {
        //Aim : The method is responsible to hold the contract for viewing the TeacherUniversity for the incoming teacher id.
        public List<TeacherUniversity> ViewTeacherUniversityRepository(int teacherId);

        //  Aim : The method is responsible to hold the contract for creating the teacher University
        public string CreateTeacherUniversity(int teacherId, int selectedUniversities);

        //Aim : The method is responsible to hold the contract for editing the teacher University.
        public string EditTeacherUniversity(List<TeacherUniversity> teacherUniversities);

    }
}
