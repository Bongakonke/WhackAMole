using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Whack_A_Mole
{
    public partial class settings : PhoneApplicationPage
    {
        public double speed = 0;
        public settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            speed = 1;
            var obj = App.Current as App;
            obj.spd = speed;
            NavigationService.Navigate(new Uri("/play.xaml?sp=" + speed, UriKind.Relative));
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            speed = 0.7;
            var obj = App.Current as App;
            obj.spd = speed;
            NavigationService.Navigate(new Uri("/play.xaml?sp=" + speed, UriKind.Relative));

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            speed = 0.5;
            var obj = App.Current as App;
            obj.spd = speed;
            NavigationService.Navigate(new Uri("/play.xaml?sp=" + speed, UriKind.Relative));

        }

              //// timer http://msdn.microsoft.com/en-us/library/system.windows.forms.timer%28v=VS.80%29.aspx
    }
}