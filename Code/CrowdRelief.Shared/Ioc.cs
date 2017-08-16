using CrowdRelief.Interfaces;
using CrowdRelief.Ioc;
using CrowdRelief.Pages;
using CrowdRelief.Services;
using CrowdRelief.ViewModels;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdRelief.Shared
{
    public class Ioc : NinjectModule
    {
        public override void Load()
        {
            Container.Register<ILoginService, LoginService>();
        }
    }
}
