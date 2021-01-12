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
using TuitionsOnlineAdmin.DataStore.EntityFramework;
using TuitionsOnlineAdmin.DataStore.EntityFramework.Persistence.Repositories;
using TuitionsOnlineAdmin.UseCases.CertificateCouses.CreateCertificateCourseScreen;
using TuitionsOnlineAdmin.UseCases.CertificateCouses.CreateCertificateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Cities.CreateCityScreen;
using TuitionsOnlineAdmin.UseCases.Cities.CreateCityScreen.Interfaces;

using TuitionsOnlineAdmin.UseCases.Curriencies.CreateCurrencyScreen;
using TuitionsOnlineAdmin.UseCases.Curriencies.CreateCurrencyScreen.Interface;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen;
using TuitionsOnlineAdmin.UseCases.DoctorateCourses.CreateDoctorateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Grades.CreateGradeScreen;
using TuitionsOnlineAdmin.UseCases.Grades.CreateGradeScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen;
using TuitionsOnlineAdmin.UseCases.GraduateCourses.CreateGraduateCourseScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.CreateHighSchoolBoardScreen;
using TuitionsOnlineAdmin.UseCases.HighSchoolBoards.CreateHighSchoolBoardScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore;
using TuitionsOnlineAdmin.UseCases.PluginInterfaces.DataStore.Repositories;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.CreatePostGraduateCourseScreen;
using TuitionsOnlineAdmin.UseCases.PostGraduateCourses.CreatePostGraduateCourseScreen.Interface;
using TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen;
using TuitionsOnlineAdmin.UseCases.Subjects.CreateSubjectScreen.Interfaces;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.CreateTeacherVideoScreen;
using TuitionsOnlineAdmin.UseCases.TeacherVideos.CreateTeacherVideoScreen.Interfaces;
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
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IGraduateCourseRepository, GraduateCourseRepository>();


            services.AddTransient<ICreatePostGraduateCourseUseCase, CreatePostGraduateCourseUseCase>();          
            services.AddTransient<IPostGraduateCourseRepository, PostGraduateCourseRepository>();


            services.AddTransient<ICreateDoctorateCourseUseCase, CreateDoctorateCourseUseCase>();          
            services.AddTransient<IDoctorateCourseRepository, DoctorateCourseRepository>();

            services.AddTransient<ICreateCertificateCourseUseCase, CreateCertificateCourseUseCase>();
            services.AddTransient<ICertificateCourseRepository, CertificateCourseRepository>();

            services.AddTransient<ICreateCityUseCase, CreateCityUseCase>();
            services.AddTransient<ICityRepository, CityRepository>();

            services.AddTransient<ICreateCurrencyUseCase, CreateCurrencyUseCase>();
            services.AddTransient<ICurrencyRepository, CurrencyRepository>();

            services.AddTransient<ICreateSubjectUseCase, CreateSubjectUseCase>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();

           services.AddTransient<ICreateTeacherVideoUseCase, CreateTeacherVideoUseCase>();
           services.AddTransient<ITeacherVideoRepository, TeacherVideoRepository>();

            services.AddTransient<ICreateGradeUseCase, CreateGradeUseCase>();
            services.AddTransient<IGradeRepository, GradeRepository>();

            services.AddTransient<ICreateHighSchoolBoardUseCase, CreateHighSchoolBoardUseCase>();
            services.AddTransient<IHighSchoolBoardRepository, HighSchoolBoardRepository>();

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
