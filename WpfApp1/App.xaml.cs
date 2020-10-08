﻿using Lierda.WPFHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        
            LierdaCracker cracker = new LierdaCracker();
            protected override void OnStartup(StartupEventArgs e)
            {
                cracker.Cracker(100);
                base.OnStartup(e);
            }
       
    }
}
