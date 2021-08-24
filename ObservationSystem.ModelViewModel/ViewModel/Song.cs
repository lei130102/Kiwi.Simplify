using GalaSoft.MvvmLight;
using Kiwi.Simplify.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObservationSystem.ModelViewModel.ViewModel
{
    [Export(typeof(IPluginViewModel))]
    [ExportMetadata("Info", new[]{"歌曲"})]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class Song : ViewModelBase, IPluginViewModel
    {
        private Model.Song song;

        public Song()
        {
            song = new Model.Song { Title = "Unknown", Artist = "Unknown" };
        }

        public string Title
        {
            get
            {
                return song.Title;
            }
            set
            {
                if(song.Title != value)
                {
                    song.Title = value;

                    RaisePropertyChanged(() => Title);
                }
            }
        }

        public string Artist
        {
            get
            {
                return song.Artist;
            }
            set
            {
                if(song.Artist != value)
                {
                    song.Artist = value;

                    RaisePropertyChanged(() => Artist);
                }
            }
        }
    }
}
