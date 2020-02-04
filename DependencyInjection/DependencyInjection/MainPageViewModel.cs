using DependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class MainPageViewModel
    {
        IDataService dataService;
        public MainPageViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public void DoIt()
        {
            dataService.DoStuff();
        }
    }
}
