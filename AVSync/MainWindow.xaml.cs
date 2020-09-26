using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AVSync
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            waveform.RegisterSoundPlayer(((MainWindowVM)DataContext).Player);
        }
         
        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            var openFileWindow = new Microsoft.Win32.OpenFileDialog();
            var result = openFileWindow.ShowDialog();
            if (result == true)
            {
                ((MainWindowVM) DataContext).VideoPath = openFileWindow.FileName;
            }
        }
    }
}
