using Ninject;
using Northwind.Bussines.Concrete;
using Northwind.DAL.Concrete;
using Northwind.Interfaces;
using Northwind.WCF.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Northwind.MVCWebUI.Infrastructure
{
    public class NinjectControllerFactory:DefaultControllerFactory
    {
        private IKernel _ninjectKernel;

        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBllBindings();
            //AddServiceBindings();
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IProductService>().To<ProductManager>().WithConstructorArgument("productDal",new ProductDAL());
        }

        //private void AddServiceBindings()
        //{
        //    _ninjectKernel.Bind<IProductService>().To<ProductService>();
        //}
         protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }
    }
}