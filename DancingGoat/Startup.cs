﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DancingGoat.Startup))]

namespace DancingGoat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}