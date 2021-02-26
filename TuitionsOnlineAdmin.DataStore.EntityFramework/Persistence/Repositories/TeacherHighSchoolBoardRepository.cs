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

        public List<TeacherHighSchoolBoardWithForeignKeys> ViewTeacherHighSchoolBoardRepository(int teacherId)
        {
            Console.WriteLine(teacherId);
            List<TeacherHighSchoolBoard> teacherHighSchoolBoardList = new List<TeacherHighSchoolBoard>();
            List<TeacherHighSchoolBoardWithForeignKeys> teacherHighSchoolBoardWithForeignKeyList = new List<TeacherHighSchoolBoardWithForeignKeys>() { };
            TeacherHighSchoolBoardWithForeignKeys teacherHighSchoolBoardWithForeignKey = new TeacherHighSchoolBoardWithForeignKeys();
            //  List<TeacherHighSchoolBoardWithForeignKeys> list = new List<TeacherHighSchoolBoardWithForeignKeys>();
            try
            {
                if (teacherId != 0)
                {
                    //Console.WriteLine(teacherId);
                    teacherHighSchoolBoardList = diTuitionsOnlineAdminDbContext.TeacherHighSchoolBoard.Where(s => s.TeacherId == teacherId).ToList();
                    Console.WriteLine(teacherHighSchoolBoardList);
                    foreach (var teacherHighSchoolBoard in teacherHighSchoolBoardList)
                    {
                        var list1 = new List<TeacherHighSchoolBoardWithForeignKeys>();
                        Console.WriteLine(teacherHighSchoolBoardWithForeignKeyList);
                        var TeacherDetails = diTuitionsOnlineAdminDbContext.TeacherBasicInformation.FirstOrDefault(s => s.TeacherId == teacherHighSchoolBoard.TeacherId);
                        var HighSchoolBoardDetails = diTuitionsOnlineAdminDbContext.HighSchoolBoard.FirstOrDefault(s => s.HighSchoolBoardId == teacherHighSchoolBoard.HighSchoolBoardId);
                        teacherHighSchoolBoardWithForeignKeyList.Add(new TeacherHighSchoolBoardWithForeignKeys()
                        {
                            TeacherName = TeacherDetails.Teacher_Name,
                            HighSchoolBoardName = HighSchoolBoardDetails.HighSchoolBoardName,
                            HighSchoolBoardId = HighSchoolBoardDetails.HighSchoolBoardId,
                            TeacherId = TeacherDetails.TeacherId,
                            TeacherHighSchoolBoardId = teacherHighSchoolBoard.TeacherHighSchoolBoardId
                        });
                    }
                }
                if (teacherHighSchoolBoardWithForeignKeyList == null)
                {
                    teacherHighSchoolBoardWithForeignKeyList = new List<TeacherHighSchoolBoardWithForeignKeys>();
                }
                return teacherHighSchoolBoardWithForeignKeyList;
            }
            catch (Exception)
            {
                return teacherHighSchoolBoardWithForeignKeyList = null;
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
 
 
