﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace RestWithASP.netUDEMY
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHost(args).Run();
        }

        public static IWebHost CreateWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
