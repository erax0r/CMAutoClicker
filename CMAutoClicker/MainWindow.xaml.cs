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

namespace CMAutoClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AutoClicker autoClicker = new AutoClicker();
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            autoClicker.ClickMouse(Convert.ToInt32(this.xcoords.Text),Convert.ToInt32(this.ycoords.Text),Convert.ToInt32(this.duration.Text),Convert.ToInt32(this.interval.Text));
        }

    }
}
