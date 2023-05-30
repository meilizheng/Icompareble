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

namespace Icompareble
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Waterbottle> _waterbottles = new List<Waterbottle>(); //created a list;
        public MainWindow()
        {
             InitializeComponent();
            _waterbottles.Add(new Waterbottle(22.5, "glass", 9, "round"));  //add data to the list;
            _waterbottles.Add(new Waterbottle(24.97, "copper", 32, "oval"));
            _waterbottles.Add(new Waterbottle(26.98, "steel", 9, "round"));
            _waterbottles.Add(new Waterbottle(64.95, "steel", 128, "rectangular"));
            _waterbottles.Add(new Waterbottle(9.80, "plastic", 32, "round"));
            lbDisplay.ItemsSource = _waterbottles;
        }

        private void btnPrice_Click(object sender, RoutedEventArgs e)
        {
            WaterbottleComparePrice price = new WaterbottleComparePrice(); //created a new instance sort data by price;
            _waterbottles.Sort(price);
            lbDisplay.Items.Refresh();
        }

        private void btncapacity_Click(object sender, RoutedEventArgs e)
        {
            _waterbottles.Sort();
            lbDisplay.Items.Refresh();
        }

        private void btnShape_Click(object sender, RoutedEventArgs e)
        {
            WaterbottleCompareShape shape = new WaterbottleCompareShape();//created a new instance sort data by shape;
            _waterbottles.Sort(shape);
            lbDisplay.Items.Refresh();
        }
    }
}
