using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Services
{
    public class MyDataService : IDataService
    {
        ILogger<MyDataService> logger;
        public MyDataService(ILogger<MyDataService> logger)
        {
            this.logger = logger;
        }

        public void DoStuff()
        {
            logger.LogCritical("You just called DoStuff from MyDataService");
        }
    }
}
