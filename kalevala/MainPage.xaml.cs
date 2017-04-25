using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace kalevala
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
            // Starts game
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player { Name1 = Player1.Text, Name2 = Player2.Text  };
            
            this.Frame.Navigate(typeof(GamePage),player);
        }

        private void HighScore_Click(object sender, RoutedEventArgs e)
        {
            // navigate to Highscore  page
            Frame.Navigate(typeof(Scores));
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            CoreApplication.Exit();
            
            
            Debug.WriteLine("peli loppui");
        }
    }
}
