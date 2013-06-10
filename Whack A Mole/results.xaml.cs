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
    public partial class results : PhoneApplicationPage
    {
        public int score = 0;
        public results()
        {
            InitializeComponent();
            var obj = App.Current as App;
            
            textBlock1.Text = Convert.ToString(obj.score);
            
        }

        
        
    }
}