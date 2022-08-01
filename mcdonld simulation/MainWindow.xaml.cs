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

namespace mcdonld_simulation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            outside_mcd.Visibility = Visibility.Hidden;
            go_in_mcd.Visibility = Visibility.Hidden;
            cheeseburger.Visibility = Visibility.Visible;
            cheeseburg.Visibility = Visibility.Visible;
            mic_chicken_balls.Visibility = Visibility.Visible;
            mc_chicken_buttn.Visibility = Visibility.Visible;
            mealbutton.Visibility = Visibility.Visible;
            mealimage.Visibility = Visibility.Visible;
        }
        private void cheeseclick(object sender, RoutedEventArgs e)
        {
            cheesemcd.Visibility = Visibility.Visible; 
            cheeseburger.Visibility = Visibility.Hidden;
            cheeseburg.Visibility = Visibility.Hidden;
            mealimage.Visibility = Visibility.Hidden;
            mealbutton.Visibility = Visibility.Hidden;
            mc_chicken_buttn.Visibility = Visibility.Hidden;
            mcchick.Visibility = Visibility.Visible;
        }
        private void mcchicken(object sender, RoutedEventArgs e)
        {
            cheesemcd.Visibility = Visibility.Hidden;
            cheeseburger.Visibility = Visibility.Hidden;
            cheeseburg.Visibility = Visibility.Hidden;
            mic_chicken_balls.Visibility = Visibility.Hidden;
            mc_chicken_buttn.Visibility = Visibility.Hidden;
            mcchick.Visibility = Visibility.Visible;
            mealimage.Visibility= Visibility.Hidden;
            mealbutton.Visibility= Visibility.Hidden;

        }

        private void meallol(object sender, RoutedEventArgs e)
        {
            cheesemcd.Visibility = Visibility.Hidden;
            cheeseburger.Visibility = Visibility.Hidden;
            cheeseburg.Visibility = Visibility.Hidden;
            mic_chicken_balls.Visibility = Visibility.Hidden;
            mc_chicken_buttn.Visibility = Visibility.Hidden;
            mealimageout.Visibility = Visibility.Visible;
        }
    }
}

