﻿using System;
using ControleEstoque.Mvc;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ControleEstoque.Mvc.Startup))]

namespace ControleEstoque.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
