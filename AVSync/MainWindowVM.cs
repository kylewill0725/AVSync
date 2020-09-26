using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Input;
using Un4seen.Bass;
using WPFSoundVisualizationLib;

namespace AVSync
{
    public class MainWindowVM : BaseVM
    {
        private string _videoPath;
        private bool _isPlaying;
        private BassEngine _player;

        public MainWindowVM()
        {
            PropertyChanged += OnVideoPathChanged;
        }

        #region Properties
        public bool IsPlaying
        {
            get => _isPlaying;
            set
            {
                if (value == _isPlaying) return;
                _isPlaying = value;
                OnPropertyChanged();
            }
        }

        public string VideoPath
        {
            get => _videoPath;
            set
            {
                if (value == _videoPath) return;
                _videoPath = value;
                OnPropertyChanged();
            }
        }

        public IWaveformPlayer Player => BassEngine.Instance;

        #endregion

        #region Commands

        #endregion

        #region Events
        
        private void OnVideoPathChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != nameof(VideoPath)) return;

            _player.OpenFile(VideoPath);
        }

        #endregion
    }
}