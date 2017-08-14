using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdRelief.Ioc
{
    public class Container
    {
        private static StandardKernel instance { get; set; }

        public static void Initialize()
        {
            var kernel = new StandardKernel();
            instance = kernel;
            //Remove below code and hope for the best
            instance.Load(new Shared.Ioc());
            
        }

        public static void Register<I,T>() where T : class, I where I : class
        {
            instance.Bind<I>().To<T>();          
        }

        public static I Get<I>() where I : class
        {
            return instance.Get<I>();
        }
    }
}
