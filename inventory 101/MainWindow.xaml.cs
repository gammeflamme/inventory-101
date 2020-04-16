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

namespace inventory_101
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int debug;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            debug = Category_selection.SelectedIndex;
            debugoutput.Text = debug.ToString();
            
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool visible = (Category_selection.Visibility == Visibility.Visible);

            if (visible)
            {
                Category_selection.Visibility = Visibility.Collapsed;
            }
            else 
            {
                Category_selection.Visibility = Visibility.Visible;
            }
        }
    }
}
