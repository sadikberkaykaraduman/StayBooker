using Microsoft.Extensions.DependencyInjection;
using StayBooker.BusinessLayer.Abstract;
using StayBooker.BusinessLayer.Concrete;
using StayBooker.DataAccessLayer.Abstract;
using StayBooker.DataAccessLayer.Concrete;
using StayBooker.DataAccessLayer.EntityFramework;
using System.Reflection;

namespace StayBooker.WebApi.Extension
{
    public static class ServiceRegistrationExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services)
        {
            services.AddDbContext<Context>();

            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IBookingDal, EfBookingDal>();
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IGuestDal, EfGuestDal>();
            services.AddScoped<IMessageCategoryDal, EfMessageCategoryDal>();
            services.AddScoped<ISendMessageDal, EfSendMessageDal>();
            services.AddScoped<IWorkLocationDal, EfWorkLocationDal>();

            services.AddScoped<IRoomService, RoomManager>();
            services.AddScoped<IServiceService, ServiceManager>();
            services.AddScoped<IStaffService, StaffManager>();
            services.AddScoped<ISubscribeService, SubscribeManager>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IBookingService, BookingManager>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IGuestService, GuestManager>();
            services.AddScoped<IMessageCategoryService, MessageCategoryManager>();
            services.AddScoped<ISendMessageService, SendMessageManager>();
            services.AddScoped<IWorkLocationService, WorkLocationManager>();


            services.AddCors(opt =>
            {
                opt.AddPolicy("HotelApiCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddAutoMapper(Assembly.GetExecutingAssembly());



            return services;
        }
    }
}
