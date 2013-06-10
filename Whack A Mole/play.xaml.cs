using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Threading;
using System.Windows.Threading;

namespace Whack_A_Mole
{
    public partial class play : PhoneApplicationPage
    {
        DispatcherTimer timer = new DispatcherTimer();
        public int score = 0;
        public double speed = 0;
        public int count = 0;

        public play()
        {

            InitializeComponent();
            var obj = App.Current as App;
            speed = obj.spd;
            timer.Interval = TimeSpan.FromSeconds(speed);
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }


        public void timer_Tick(object sender, EventArgs e)
        {

            var obj = App.Current as App;

            Random ran = new Random();
            int num = ran.Next(1, 8);
            obj.rand = num;

            if (num == 1)
            {
                hide();
                image1.Source = new BitmapImage(new Uri("Images/mole.png", UriKind.RelativeOrAbsolute));

            }

            if (num == 2)
            {
                hide();
                image2.Source = new BitmapImage(new Uri("Images/mole.png", UriKind.RelativeOrAbsolute));

            }
            if (num == 3)
            {
                hide();
                image3.Source = new BitmapImage(new Uri("Images/mole.png", UriKind.RelativeOrAbsolute));
            } if (num == 4)
            {
                hide();
                image4.Source = new BitmapImage(new Uri("Images/mole.png", UriKind.RelativeOrAbsolute));
            }
            if (num == 5)
            {
                hide();
                image5.Source = new BitmapImage(new Uri("Images/mole.png", UriKind.RelativeOrAbsolute));

            }
            if (num == 6)
            {
                hide();
                image6.Source = new BitmapImage(new Uri("Images/mole.png", UriKind.RelativeOrAbsolute));
            }

            if (num == 7)
            {
                hide();
                image7.Source = new BitmapImage(new Uri("Images/mole.png", UriKind.RelativeOrAbsolute));

            }


            textBlock1.Text = "SCORE: " + Convert.ToString(score);
            count += 1;
            nmb.Text = Convert.ToString(count);
            if (count == 60)
            {
                timer.Stop();
                PageTitle.Text = "YOUR SCORE IS : "+score+" GAME OVER!  CLICK BACK FOR MORE";
                ContentPanel.Visibility = Visibility.Collapsed;

            }

        }

        

        public void hide()
        {
            image1.Source = new BitmapImage(new Uri("Images/hole.png", UriKind.RelativeOrAbsolute));
            image2.Source = new BitmapImage(new Uri("Images/hole.png", UriKind.RelativeOrAbsolute));
            image3.Source = new BitmapImage(new Uri("Images/hole.png", UriKind.RelativeOrAbsolute));
            image4.Source = new BitmapImage(new Uri("Images/hole.png", UriKind.RelativeOrAbsolute));
            image5.Source = new BitmapImage(new Uri("Images/hole.png", UriKind.RelativeOrAbsolute));
            image6.Source = new BitmapImage(new Uri("Images/hole.png", UriKind.RelativeOrAbsolute));
            image7.Source = new BitmapImage(new Uri("Images/hole.png", UriKind.RelativeOrAbsolute));
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            int num = 0;
            num = obj.rand;
            if (num == 1)
                score += 1;
            var scr = App.Current as App;
            scr.score = score;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            int num = 0;
            num = obj.rand;
            if (num == 4)
                score += 1;
            var scr = App.Current as App;
            scr.score = score;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            int num = 0;
            num = obj.rand;
            if (num == 2)
                score += 1;
            var scr = App.Current as App;
            scr.score = score;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            int num = 0;
            num = obj.rand;
            if (num == 7)
                score += 1;
            var scr = App.Current as App;
            scr.score = score;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            int num = 0;
            num = obj.rand;
            if (num == 5)
                score += 1;
            var scr = App.Current as App;
            scr.score = score;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            int num = 0;
            num = obj.rand;
            if (num == 3)
                score += 1;
            var scr = App.Current as App;
            scr.score = score;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            var obj = App.Current as App;
            int num = 0;
            num = obj.rand;
            if (num == 6)
                score += 1;
            
        }


        
       
    }
}