using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Extensions
{
    public static class ServiceExtensions
    {

        public static IServiceCollection AddProjectDependencies(this IServiceCollection services)
        {
           
            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();

           
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();

          
            services.AddScoped<IDestinationDal, EfDestinationDal>();
            services.AddScoped<IDestinationService, DestinationManager>();

            
            services.AddScoped<IFeatureDal, EfFeatureDal>();
            services.AddScoped<IFeatureService, FeatureManager>();

          
            services.AddScoped<IGuideDal, EfGuideDal>();
            services.AddScoped<IGuideService, GuideManager>();

            
            services.AddScoped<INewsLetterDal, EfNewsLetterDal>();
            services.AddScoped<INewsLetterService, NewsLetterManager>();

      
            services.AddScoped<ISecondaryAboutDal, EfSecondaryAboutDal>();
            services.AddScoped<ISecondaryAboutService, SecondaryAboutManager>();

           
            services.AddScoped<ISecondaryFeatureDal, EfSecondaryFeatureDal>();
            services.AddScoped<ISecondaryFeatureService, SecondaryFeatureManager>();

           
            services.AddScoped<ISubAboutDal, EfSubAboutDal>();
            services.AddScoped<ISubAboutService, SubAboutManager>();

          
            services.AddScoped<ITestimonialsDal, EfTestimonialsDal>();
            services.AddScoped<ITestimonialsService, TestimonialsManager>();

            return services;
        }
    }
}

