using Kiwi.Simplify.Interface;
using Kiwi.Simplify.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservationSystem.View
{
    public class ViewModelLocator
    {
        public object Song
        {
            get
            {
                return PluginCatalogService.Instance.GetPlugin<IPluginViewModel>("歌曲");
            }
        }

        public object Second
        {
            get
            {
                return PluginCatalogService.Instance.GetPlugin<IPluginViewModel>("新窗口");
            }
        }
    }
}
