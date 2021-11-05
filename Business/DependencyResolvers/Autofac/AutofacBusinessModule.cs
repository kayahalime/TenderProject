using System;
using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Interceptors;
using Core.Utilities.Security.Jwt;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;


namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdminManager>().As<IAdminService>().SingleInstance();
            builder.RegisterType<EfAdminDal>().As<IAdminDal>().SingleInstance();
            builder.RegisterType<BidManager>().As<IBidService>().SingleInstance();
            builder.RegisterType<EfBidDal>().As<IBidDal>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();
            builder.RegisterType<ClientManager>().As<IClientService>().SingleInstance();
            builder.RegisterType<EfClientDal>().As<IClientDal>().SingleInstance();
            builder.RegisterType<ImageManager>().As<IImageService>().SingleInstance();
            builder.RegisterType<EfImageDal>().As<IImageDal>().SingleInstance();
            builder.RegisterType<TenderManager>().As<ITenderService>().SingleInstance();
            builder.RegisterType<EfTenderDal>().As<ITenderDal>().SingleInstance();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}
