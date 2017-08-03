using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;//引用MVC框架
using Ninject;//需要添加的引用
using System.Web.Routing;//需要添加的引用
using BookShop.Domain;//需要添加的引用

//自定义一个继承至DefaultControllerFactory的工厂类
//可以扩展controller
namespace BookShop.WebUI
{
    public class NinjectControllerFactory: DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBindings()
        {
            // todo:后面再来添加绑定
            ninjectKernel.Bind<IBookRepository>().To<BookRepository>();
        }
    }
}