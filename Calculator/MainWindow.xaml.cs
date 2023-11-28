using System.CodeDom;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastNumber, result;

        public MainWindow()
        {
            InitializeComponent();

            acButton.Click += AcButton_Click1;
            negButton.Click += NegButton_Click1;
            percButton.Click += PercButton_Click1;
            equalButton.Click += EqualButton_Click1;
        }

        private void EqualButton_Click1(object sender, RoutedEventArgs e)
        {
            
        }

        private void PercButton_Click1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber / 100;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void NegButton_Click1(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(resultLabel.Content.ToString(), out lastNumber))
            {
                lastNumber = lastNumber * -1;
                resultLabel.Content = lastNumber.ToString();
            }
        }

        private void AcButton_Click1(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "0";
        }

        private void ZeroButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OneButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TwoButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ThreeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FourButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FiveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SixButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SevenButton_Click(object sender, RoutedEventArgs e)
        {
            if(resultLabel.Content.ToString() == "0")
            {
                resultLabel.Content = "7";
            } else
            {
                resultLabel.Content = $"{resultLabel.Content}7";
            }
        }

        private void EightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NineButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FracButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MultButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DivButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PercButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NegButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AcButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}