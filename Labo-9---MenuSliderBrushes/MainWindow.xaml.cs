using System.Reflection.Emit;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_9___MenuSliderBrushes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object trackBar1;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void cloesMenu_Click(object sender, RoutedEventArgs e)
        {
        if (MessageBox.Show("Ben je zeker dat u wilt afsluiten?",
            "Afsluiten", MessageBoxButton.YesNo, MessageBoxImage.Question)
             == MessageBoxResult.Yes)
             {
                this.Close();
             }
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if(sender == firstNumberMenu)
            {
                numberOneTextBox.Text = "2";
            }
            else if (sender == secondNumberMenu)
            {
                numberTwoTextBox.Text = "2";
            }
        }

        private void numberOneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(int.TryParse(numberOneTextBox.Text, out int value))
            {
                if(value >=1 && value <= 5)
                {
                    slider1.Value = value;
                }
            }
        }

        private void numberTwoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (int.TryParse(numberTwoTextBox.Text, out int value))
            {
                if (value >= 1 && value <= 5)
                {
                    slider2.Value = value;
                }
            }
        }
        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberOneTextBox.Text = slider1.Value.ToString();
        }
        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            numberTwoTextBox.Text = slider2.Value.ToString();

        }
    }
}