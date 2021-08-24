using Kiwi.Simplify.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservationSystem.ModelViewModel.Model
{
    [Export(typeof(IPluginModel))]
    [ExportMetadata("Info", new[] {"歌曲"})]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Song : IPluginModel
    {
        /// <summary>
        /// 标题
        /// </summary>
        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        /// <summary>
        /// 作曲者
        /// </summary>
        private string artist;
        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }
    }
}
