using System;
using System.Web;
using Ninject;
using Ninject.Web.Common;

namespace DotnetWebScaffold.App_Start
{
    public static class StandardKernelProvider
    {
        public static IKernel GetKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }
    }
}