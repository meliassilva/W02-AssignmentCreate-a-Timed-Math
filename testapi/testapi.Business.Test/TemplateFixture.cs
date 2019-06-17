﻿using System;
using Byui.testapi.Business.Entities;
using Byui.testapi.Business.Utilities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Byui.testapi.Business.Test
{
    public class TemplateFixture : IDisposable
    {

        public readonly IServiceProvider ServiceProvider;

        public TemplateFixture()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<TemplateFixture>();

            IConfigurationRoot config = builder.Build();

            var services = new ServiceCollection();

            var appSettings = Configuration.Configure(services, config, true);

            ServiceProvider = services.BuildServiceProvider();

            if (string.IsNullOrEmpty(appSettings.ConnectionString))
            {
                Setup();
            }

        }

        /// <summary>
        /// Run to setup in memory database.
        /// </summary>
        private void Setup()
        {
            var ctx = ServiceProvider.GetService<testapiContext>();
        }

        public void Dispose()
        {
            
        }
    }
}
