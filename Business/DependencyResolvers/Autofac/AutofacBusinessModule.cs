using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using CorePackages.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<BookManager>().As<IBookService>().SingleInstance();
        builder.RegisterType<EfBookDal>().As<IBookDal>().SingleInstance();

        
        builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
        builder.RegisterType<EfCategoryDal>().As<ICategoryDal>().SingleInstance();

        builder.RegisterType<PublisherManager>().As<IPublisherService>().SingleInstance();
        builder.RegisterType<EfPublisherDal>().As<IPublisherDal>().SingleInstance();

        builder.RegisterType<AuthorManager>().As<IAuthorService>().SingleInstance();
        builder.RegisterType<EfAuthorDal>().As<IAuthorDal>().SingleInstance();
        






        var assembly = System.Reflection.Assembly.GetExecutingAssembly();

        builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
            .EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
    }








}
