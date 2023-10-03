﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bukinist.ViewModels
{
    class ViewModelLocator
    {

        public MainWindowViewModel MainWindowModel => App.Services.GetRequiredService<MainWindowViewModel>()
            ;

    }
}
