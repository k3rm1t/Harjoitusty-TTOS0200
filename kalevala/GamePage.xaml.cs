using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
//using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static kalevala.ScoreCount;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace kalevala
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GamePage : Page 
    {
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Here Player names come to GamePage
            if (e.Parameter is Player)
            {
                Player player = (Player)e.Parameter;
                Playername1.Text = player.Name1;
                Playername2.Text = player.Name2;
            }
            else
            {
                
                Playername1.Text = "Unknown";
                Playername2.Text = "tuntematon";
            }
            base.OnNavigatedTo(e);
        }
        int count = 0;
        // click counter. if count is 30 game should end
       private async System.Threading.Tasks.Task<int> ClickCounter()
        {
            count++;
            Debug.WriteLine(count);
            if (count != 30)
            {
                return count;
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog("Peli loppui!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(MainPage));
                return 0;
            }           
        }
        /*
        //add scores
        private int Score;
        public int NewScore { get; set; }
      
          private void AddScore()
          {  
              Score += NewScore;
              UpdateScore();
            return NewScore;           
          }
          // decrease scores
          private int DecScore()
          {
              Score -= NewScore;
              UpdateScore();
              return NewScore;
          }
          //updates scores

          void UpdateScore()
          {

              // currentplayer.Text = Convert.Tostring(Score);
              //scoreText.text = "Score: " + score; //orginall
              Player1Points.Text = Convert.ToString(NewScore);//NewScore.ToString(); // 
              return;
          }
  */

        private void InitializeComponents()
        {

        }
        public GamePage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
        
        //Score score = new ScoreCount();
       
        public int points = 0;
        //private int NewScore;

        private async void WaterButton_Click(object sender, RoutedEventArgs e )
        {
            
            // painettu kuva
            Image image = sender as Image;
            BitmapImage BitmapImage = new BitmapImage();
            //image.Source = new BitmapImage(new Uri("ms-appx:///Assets/ahven.png"));

            Debug.WriteLine("testi");

            Random random = new Random();
            int rand = random.Next(0, 100);
          
            if (rand < 49)
            {
                if (rand < 49 && rand > 40)
                {
                    image.Source = new BitmapImage(new Uri("ms-appx:///Assets/man.png")); Debug.WriteLine("nuuskamuikkunen");
                   // System.Windows.Application a = System.Windows.Application.Current;
                    //(ScoreCount.Current as ScoreCount).Number = NewScore;
                   // Frame rootFrame = Window.Current.Content as Frame;
                    points++;
                    Player1Points.Text = Convert.ToString(points);
                }
                else if (rand > 29 && rand < 39)
                {
                    image.Source=new BitmapImage(new Uri("ms-appx:///Assets/robber.png")); Debug.WriteLine("haisuli");
                    points --;
                    Player1Points.Text = Convert.ToString(points);
                }
                
                else if (rand <29 && rand >20) {
                    image.Source = new BitmapImage(new Uri("ms-appx:///Assets/hauki.png")); }// laita naihin tapahtumaan oikeita asioita
                    points++;
                    Player1Points.Text = Convert.ToString(points);
                }
            else
            {
                image.Source = new BitmapImage(new Uri("ms-appx:///Assets/wave.png"));
                Debug.WriteLine("ei kalaa");
                
            }
           
             int x =await ClickCounter();
            var parameters = new Player();
            parameters.Name1 = Playername1.Text;
            
    }

        private void EndGame_Click(object sender, RoutedEventArgs e)
        {
            Frame RootFrame = Window.Current.Content as Frame;
            if (RootFrame == null) return;
            if (RootFrame.CanGoBack)
            {
                RootFrame.GoBack();
            }
        }
    }
}
