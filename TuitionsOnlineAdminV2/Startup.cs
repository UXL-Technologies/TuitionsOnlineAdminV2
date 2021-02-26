using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuitionsOnlineAdmin.CoreBusiness;
using TuitionsOnlineAdmin.DataStore.EntityFramework;
using TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories;
using TuitionsOnlineAdmin.UseCases.CertificateCourses.UpdateCertificateCourseScreen;
using TuitionsOnlineAdmin.UseCases.CertificateCourses.UpdateCertificateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.CertificateCourses.ViewCertificateCourseScreen;
using TuitionsOnlineAdmin.UseCases.CertificateCourses.ViewCertificateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.CertificateCouses.CreateCertificateCourseScreen;
using TuitionsOnlineAdmin.UseCases.CertificateCouses.CreateCertificateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Cities.CreateCityScreen;
using TuitionsOnlineAdmin.UseCases.Cities.CreateCityScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Cities.UpdateCityScreen;
using TuitionsOnlineAdmin.UseCases.Cities.UpdateCityScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Cities.ViewCityScreen;
using TuitionsOnlineAdmin.UseCases.Cities.ViewCityScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Currencies.CreateCurrencyScreen;
using TuitionsOnlineAdmin.UseCases.Currencies.CreateCurrencyScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Currencies.UpdateCurrencyScreen;
using TuitionsOnlineAdmin.UseCases.Currencies.UpdateCurrencyScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Currencies.ViewCurrencyScreen;
using TuitionsOnlineAdmin.UseCases.Currencies.ViewCurrencyScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.UpdateDoctorateCourseScreen;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.UpdateDoctorateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.ViewDoctorateCourseScreen;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.ViewDoctorateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Grades.CreateGradeScreen;
using TuitionsOnlineAdmin.UseCases.Grades.CreateGradeScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Grades.UpdateGradeScreen;
using TuitionsOnlineAdmin.UseCases.Grades.UpdateGradeScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Grades.ViewGradeScreen;
using TuitionsOnlineAdmin.UseCases.Grades.ViewGradeScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.UpdateGraduateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.ViewGraduateCourseScreen;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.ViewGraduateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.CreateHighSchoolBoardScreen;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.CreateHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.UpdateHighSchoolBoardScreen;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.UpdateHighSchoolBoardScreen.Interface;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.ViewHighSchoolBoardScreen;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.ViewHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.CreatePostGraduateCourseScreen;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.CreatePostGraduateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.UpdatePostGraduateCourseScreen;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.UpdatePostGraduateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.ViewPostGraduateCourseScreen;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.ViewPostGraduateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen;
using TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Subjects.UpdateSubjectScreen;
using TuitionsOnlineAdmin.UseCases.Subjects.UpdateSubjectScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Subjects.ViewSubjectScreen;
using TuitionsOnlineAdmin.UseCases.Subjects.ViewSubjectScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.CreateTeacherBasicInformationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.CreateTeacherBasicInformationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.UpdateTeacherbasicInformationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.UpdateTeacherbasicInformationScreen.Interface;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.ViewTeacherBasicInformationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherBasicInformations.ViewTeacherBasicInformationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.CreateTeacherCertificateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.CreateTeacherCertificateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.EditTeacherCertificateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.EditTeacherCertificateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.ViewTeacherCertificateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherCertificateCourse_Qualifications.ViewTeacherCertificateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.CreateTeacherDoctorateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.CreateTeacherDoctorateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.EditTeacherDoctorateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.EditTeacherDoctorateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.ViewTeacherDoctorateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherDoctorateCourse_Qualifications.ViewTeacherDoctorateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.CreateTeacherGraduateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.CreateTeacherGraduateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.EditGraduateCourseQualification;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.EditGraduateCourseQualification.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.ViewTeacherGraduateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourse_Qualifications.ViewTeacherGraduateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherGraduateCourseQualification.ViewTeacherGraduateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.CreateTeacherHighSchoolBoardScreen;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.CreateTeacherHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.EditTeacherHighSchoolBoardScreen;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.EditTeacherHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.ViewTeacherHighSchoolBoardScreen;
using TuitionsOnlineAdmin.UseCases.TeacherHighSchoolBoards.ViewTeacherHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.CreateTeacherPostGraduateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.CreateTeacherPostGraduateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.EditTeacherPostGraduateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.EditTeacherPostGraduateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.ViewTeacherPostGraduateCourseQualificationScreen;
using TuitionsOnlineAdmin.UseCases.TeacherPostGraduateCourse_Qualifications.ViewTeacherPostGraduateCourseQualificationScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.CreateTeacherUniversityScreen;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.CreateTeacherUniversityScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.EditTeacherUniversityScreen;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.EditTeacherUniversityScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.ViewTeacherUniversityScreen;
using TuitionsOnlineAdmin.UseCases.TeacherUniversities.ViewTeacherUniversityScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.CreateTeacherVideoScreen;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.CreateTeacherVideoScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.UpdateTeacherVideoScreen;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.UpdateTeacherVideoScreen.Interface;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.ViewTeacherVideoScreen;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.ViewTeacherVideoScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Universities.CreateUniversityScreen;
using TuitionsOnlineAdmin.UseCases.Universities.CreateUniversityScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.Universities.UpdateUniversityScreen;
using TuitionsOnlineAdmin.UseCases.Universities.UpdateUniversityScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Universities.ViewUniversityScreen;
using TuitionsOnlineAdmin.UseCases.Universities.ViewUniversityScreen.Intefaces;
using TuitionsOnlineAdminV2.Data;

namespace TuitionsOnlineAdminV2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApp(Configuration.GetSection("AzureAd"));
            services.AddControllersWithViews()
                .AddMicrosoftIdentityUI();

            services.AddAuthorization(options =>
            {
                // By default, all incoming requests will be authorized according to the default policy
                options.FallbackPolicy = options.DefaultPolicy;
            });

            services.AddRazorPages();
            services.AddServerSideBlazor()
                .AddMicrosoftIdentityConsentHandler();
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<ICreateGraduateCourseUseCase, CreateGraduateCourseUseCase>();
            services.AddTransient<IViewGraduateCourseUseCase, ViewGraduateCourseUseCase>();
            services.AddTransient<IUpdateGraduateCourseUseCase, UpdateGraduateCourseUseCase>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IGraduateCourseRepository, GraduateCourseRepository>();
            services.AddTransient<BusinessMessage>();



            services.AddTransient<ICreatePostGraduateCourseUseCase, CreatePostGraduateCourseUseCase>();
            services.AddTransient<IViewPostGraduateCourseUseCase, ViewPostGraduateCourseUseCase>();
            services.AddTransient<IPostGraduateCourseRepository, PostGraduateCourseRepository>();
            services.AddTransient<IUpdatePostGraduateCourseUseCase, UpdatePostGraduateCourseUseCase>();


            services.AddTransient<ICreateDoctorateCourseUseCase, CreateDoctorateCourseUseCase>();
            services.AddTransient<IDoctorateCourseRepository, DoctorateCourseRepository>();
            services.AddTransient<IViewDoctorateCourseUseCase, ViewDoctorateCourseUseCase>();
            services.AddTransient<IUpdateDoctorateCourseUseCase, UpdateDoctorateCourseUseCase>();


            services.AddTransient<ICreateCertificateCourseUseCase, CreateCertificateCourseUseCase>();
            services.AddTransient<ICertificateCourseRepository, CertificateCourseRepository>();
            services.AddTransient<IViewCertificateCourseUseCase, ViewCertificateCourseUseCase>();
            services.AddTransient<IUpdateCertificateCourseUseCase, UpdateCertificateCourseUseCase>();

            services.AddTransient<ICreateCityUseCase, CreateCityUseCase>();
            services.AddTransient<ICityRepository, CityRepository>();
            services.AddTransient<IViewCityUseCase, ViewCityUseCase>();
            services.AddTransient<IUpdateCityUseCase, UpdateCityUseCase>();

            services.AddTransient<ICreateCurrencyUseCase, CreateCurrencyUseCase>();
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();
            services.AddTransient<IViewCurrencyUseCase, ViewCurrencyUseCase>();
            services.AddTransient<IUpdateCurrencyUseCase, UpdateCurrencyUseCase>();


            services.AddTransient<ICreateSubjectUseCase, CreateSubjectUseCase>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient<IViewSubjectUseCase, ViewSubjectUseCase>();
            services.AddTransient<IUpdateSubjectUseCase, UpdateSubjectUseCase>();
           

            services.AddTransient<ICreateTeacherVideoUseCase, CreateTeacherVideoUseCase>();
            services.AddTransient<ITeacherVideoRepository, TeacherVideoRepository>();
            services.AddTransient<IViewTeacherVideoUseCase, ViewTeacherVideoUseCase>();
            services.AddTransient<IUpdateTeacherVideoUseCase, UpdateTeacherVideoUseCase>();

            services.AddTransient<ICreateGradeUseCase, CreateGradeUseCase>();
            services.AddTransient<IGradeRepository, GradeRepository>();
            services.AddTransient<IViewGradeUseCase, ViewGradeUseCase>();
            services.AddTransient<IUpdateGradeUseCase, UpdateGradeUseCase>();

            services.AddTransient<ICreateHighSchoolBoardUseCase, CreateHighSchoolBoardUseCase>();
            services.AddTransient<IHighSchoolBoardRepository, HighSchoolBoardRepository>();
            services.AddTransient<IViewHighSchoolBoardUseCase, ViewHighSchoolBoardUseCase>();
            services.AddTransient<IUpdateHighSchoolBoardUseCase, UpdateHighSchoolBoardUseCase>();

            services.AddTransient<ICreateTeacherBasicInformationUseCase, CreateTeacherBasicInformationUseCase>();
            services.AddTransient<ITeacherBasicInformationRepository, TeacherBasicInformationRepository>();
            services.AddTransient<IViewTeacherBasicInformationUseCase, ViewTeacherBasicInformationUseCase>();
            services.AddTransient<IUpdateTeacherBasicInformationUseCase, UpdateTeacherBasicInformationUseCase>();

            services.AddTransient<IViewTeacherGraduateCourseQualificationUseCase, ViewTeacherGraduateCourseQualificationUseCase>();
            services.AddTransient<ITeacherGraduateCourse_QualificationRepository, TeacherGraduateCourse_QualificationRepository>();
            services.AddTransient<ICreateTeacherGraduateCourseQualificationUseCase, CreateTeacherGraduateCourseQualificationUseCase>();
            services.AddTransient<IEditGraduateCourseQualificationUseCase, EditGraduateCourseQualificationUseCase>();

            services.AddTransient<IViewTeacherPostGraduateCourseQualificationUseCase, ViewTeacherPostGraduateCourseQualificationUseCase>();
            services.AddTransient<ITeacherPostGraduateCourse_QualificationRepository, TeacherPostGraduateCourse_QualificationRepository>();
            services.AddTransient<ICreateTeacherPostGraduateCourseQualificationUseCase, CreateTeacherPostGraduateCourseQualificationUseCase>();
            services.AddTransient<IEditTeacherPostGraduateCourseQualificationUseCase, EditTeacherPostGraduateCourseQualificationUseCase>();

            services.AddTransient<IViewTeacherDoctorateCourseQualificationUseCase, ViewTeacherDoctorateCourseQualificationUseCase>();
            services.AddTransient<ITeacherDoctorateCourse_QualificationRepository, TeacherDoctorateCourse_QualificationRepository>();
            services.AddTransient<ICreateTeacherDoctorateCourseQualificationUseCase, CreateTeacherDoctorateCourseQualificationUseCase>();
            services.AddTransient<IEditTeacherDoctorateCourseQualificationUseCase, EditTeacherDoctorateCourseQualificationUseCase>();


            services.AddTransient<IViewTeacherCertificateCourseQualificationUseCase, ViewTeacherCertificateCourseQualificationUseCase>();
            services.AddTransient<ITeacherCertificateCourse_QualificationRepository, TeacherCertificateCourse_QualificationRepository>();
            services.AddTransient<ICreateTeacherCertificateCourseQualificationUseCase, CreateTeacherCertificateCourseQualificationUseCase>();
            services.AddTransient<IEditTeacherCertificateCourseQualificationUseCase, EditTeacherCertificateCourseQualificationUseCase>();

            services.AddTransient<IViewTeacherHighSchoolBoardUseCase, ViewTeacherHighSchoolBoardUseCase>();
            services.AddTransient<ITeacherHighSchoolBoardRepository, TeacherHighSchoolBoardRepository>();
            services.AddTransient<ICreateTeacherHighSchoolBoardUseCase, CreateTeacherHighSchoolBoardUseCase>();
            services.AddTransient<IEditTeacherHighSchoolBoardUseCase, EditTeacherHighSchoolBoardUseCase>();

            services.AddTransient<ICreateUniversityUseCase, CreateUniversityUseCase>();
            services.AddTransient<IUniversityRepository, UniversityRepository>();
            services.AddTransient<IViewUniversityUseCase, ViewUniversityUseCase>();
            services.AddTransient<IUpdateUniversityUseCase, UpdateUniversityUseCase>();

            services.AddTransient<IViewTeacherUniversityUseCase, ViewTeacherUniversityUseCase>();
            services.AddTransient<ITeacherUniversityRepository, TeacherUniversityRepository>();
            services.AddTransient<ICreateTeacherUniversityUseCase, CreateTeacherUniversityUseCase>();
            services.AddTransient<IEditTeacherUniversityUseCase, EditTeacherUniversityUseCase>();

            var connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<TuitionsOnlineAdminDbContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
