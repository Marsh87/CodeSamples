using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSamples.Services;
using SimpleInjector;

namespace CodeSamples
{
    public class Bootstrap
    {
        public static Container Container;

        public static void Start()
        {
            Container = new Container();
            Container.Register<IBuldingService, BuildingService>(Lifestyle.Singleton);
            Container.Verify();
        }
    }
}
