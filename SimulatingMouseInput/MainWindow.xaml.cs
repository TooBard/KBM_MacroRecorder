using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using Main;

namespace SimulatingMouseInput
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            DataContext = viewModel;
        }

        private void Button_StartRecording(object sender, RoutedEventArgs e)
        {
            viewModel.SubscribeGlobal();
        }

        private void Button_StopRecording(object sender, RoutedEventArgs e)
        {
            viewModel.Unsubscribe();
        }

        private void PlayBackMacroButton_Click(object sender, EventArgs e)
        {
            viewModel.Unsubscribe();
            viewModel.Playback();
        }
        
        //private void Window_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.S)
        //    {
        //        // Call your method here
        //    }
        //}
    }
}
