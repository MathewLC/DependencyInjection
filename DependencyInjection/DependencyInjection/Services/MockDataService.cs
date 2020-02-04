using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Services
{
    public class MockDataService:IDataService
    {
        // We need access to the ILogger from Microsoft.Extensions so pass it into the constructor
        ILogger<MyDataService> logger;
        public MockDataService(ILogger<MyDataService> logger)
        {
            this.logger = logger;
        }

        public void DoStuff()
        {
            logger.LogCritical("You just called DoStuff from MockDataService");
        }
    }
}
