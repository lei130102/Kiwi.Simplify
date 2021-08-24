using Kiwi.Simplify.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ObservationSystem.View
{
    [Export(typeof(IPluginViewResourceDictionary))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class Dictionary : ResourceDictionary, IPluginViewResourceDictionary
    {
        public Dictionary()
        {
            InitializeComponent();
        }
    }
}
