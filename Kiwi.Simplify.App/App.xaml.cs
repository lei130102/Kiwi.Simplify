using Kiwi.Simplify.Interface;
using Kiwi.Simplify.Utility;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Kiwi.Simplify.App
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //加载插件
            PluginCatalogService.Instance.RegisitCatalog(AppDomain.CurrentDomain.BaseDirectory + "Plugin");

            //添加资源字典
            ResourceDictionary viewResourceDictionary = PluginCatalogService.Instance.FindPlugin<IPluginViewResourceDictionary>() as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Add(viewResourceDictionary);

            //显示窗口
            Window wnd = PluginCatalogService.Instance.FindPlugin<IPluginMainView>() as Window;
            if(wnd!=null)
            {
                wnd.Show();
            }
        }
    }
}
