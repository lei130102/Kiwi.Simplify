using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiwi.Simplify.Interface
{
    public interface IPluginResourceDictionary : IPlugin
    {
    }

    /// <summary>
    /// View的ResourceDictionary
    /// </summary>
    public interface IPluginViewResourceDictionary : IPluginResourceDictionary
    {

    }
}
