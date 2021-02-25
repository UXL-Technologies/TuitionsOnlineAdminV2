//Authors: SA, BM, SM,BA ,KK
//Date:25-Feb-2021
//Aim: implementing the inteface ITeacherHighSchoolBoardRepository 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;

namespace TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories
{
    public class TeacherHighSchoolBoardRepository : ITeacherHighSchoolBoardRepository
    {

        //property dependency injection
        private readonly TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext;
        //constructor dependency injection
        public TeacherHighSchoolBoardRepository(TuitionsOnlineAdminDbContext diTuitionsOnlineAdminDbContext)
        {
            this.diTuitionsOnlineAdminDbContext = diTuitionsOnlineAdminDbContext;
        }

        //Aim : To view HighSchoolBoard from the database

        public List<TeacherHighSchoolBoard> ViewTeacherHighSchoolBoardRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherHighSchoolBoard> teacherHighSchoolBoardList = new List<TeacherHighSchoolBoard>();

            try
            {
                if (teacherId != 0)
                {
                    Console.WriteLine(teacherId);
                    teacherHighSchoolBoardList = diTuitionsOnlineAdminDbContext.TeacherHighSchoolBoard.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherHighSchoolBoardList);
                    if (teacherHighSchoolBoardList == null)
                    {
                        teacherHighSchoolBoardList = new List<TeacherHighSchoolBoard>();
                    }
                }
                Console.WriteLine(teacherHighSchoolBoardList);
                return teacherHighSchoolBoardList;


            }
            catch (Exception)
            {
                return teacherHighSchoolBoardList = null;

            }

        }
        //Aim : To create Teacher HighSchoolBoard in the database
        public string CreateTeacherHighSchoolBoard(int teacherId, int selectedHighSchoolBoards)
        {
            Console.WriteLine(teacherId);
            Console.WriteLine(selectedHighSchoolBoards);
            try
            {
                Console.WriteLine(teacherId);
                Console.WriteLine(selectedHighSchoolBoards);

                var teacherHighSchoolBoard = new TeacherHighSchoolBoard{TeacherId = teacherId, HighSchoolBoardId = selectedHighSchoolBoards};
                Console.WriteLine(teacherHighSchoolBoard);
                diTuitionsOnlineAdminDbContext.TeacherHighSchoolBoard.Add(teacherHighSchoolBoard);

                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {


                BusinessMessage businessMessage = new BusinessMessage();
                Console.WriteLine(businessMessage);
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_SUBJECT;
            }
        }

        //Aim : To remove Teacher HighSchoolBoards from the database
        public string EditTeacherHighSchoolBoard(List<TeacherHighSchoolBoard> teacherHighSchoolBoards)
        {
            try
            {
                foreach (var teacherHighSchoolBoard in teacherHighSchoolBoards)
                {
                    diTuitionsOnlineAdminDbContext.TeacherHighSchoolBoard.Remove(teacherHighSchoolBoard);
                }
                diTuitionsOnlineAdminDbContext.SaveChanges();
                return "done";
            }
            catch (Exception)
            {
                BusinessMessage businessMessage = new BusinessMessage();
                return businessMessage.UNKNOWN_SERVER_ERROR_CREATE_SUBJECT;
            }
        }
    }
}
 
 
