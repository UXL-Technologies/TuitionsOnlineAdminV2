//Authors: SA, BM, SM , BA, KK
//Date:25-Feb-2021
//Aim: defining the pluginInterface  Repository  for TeacherHighSchoolBoard;

using System;
using System.Collections.Generic;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;

namespace TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories
{
    public interface ITeacherHighSchoolBoardRepository
    {
        //Aim : The method is responsible to hold the contract for viewing the TeacherHighSchoolBoard for the incoming teacher id.
        public List<TeacherHighSchoolBoardWithForeignKeys> ViewTeacherHighSchoolBoardRepository(int teacherId);

        //  Aim : The method is responsible to hold the contract for creating the teacher HighSchoolBoard
        public string CreateTeacherHighSchoolBoard(int teacherId, int selectedHighSchoolBoards);

        //Aim : The method is responsible to hold the contract for editing the teacher HighSchoolBoard.
        public string EditTeacherHighSchoolBoard(List<TeacherHighSchoolBoard> teacherHighSchoolBoards);
    }
}
