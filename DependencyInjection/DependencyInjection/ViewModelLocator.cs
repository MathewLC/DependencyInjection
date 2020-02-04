using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public  class ViewModelLocator
    {
        public  MainPageViewModel MainPageViewModel => (MainPageViewModel)Startup.ServiceProvider.GetService(typeof(MainPageViewModel));
    }
}
