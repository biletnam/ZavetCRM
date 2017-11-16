using CRMZavet.BLL.Interfaces;
using CRMZavet.BLL.Services;
using CRMZavet.DAL.EF;
using CRMZavet.DAL.Interfaces;
using CRMZavet.DAL.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace CRMZavet
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer()
                .RegisterType<ICrmContext, CrmContext>()
                .RegisterType<IUnitOfWork, UnitOfWork>()
                .RegisterType<IDetailOnProduct, DetailOnProduct>()
                .RegisterType(typeof(IBaseRepository<>), typeof(BaseRepository<>));


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}