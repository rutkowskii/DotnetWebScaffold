using Ninject;
using DotnetWebScaffold.App_Start;

namespace DotnetWebScaffold.Tests
{
    public class TestsBase
    {
        private static IKernel _kernel;
        
        protected T ResolveInstance<T>()
        {
            if (_kernel == null)
            {
                _kernel = StandardKernelProvider.GetKernel();
            }
            var result = _kernel.Get<T>();
            return result;
        }
    }
}