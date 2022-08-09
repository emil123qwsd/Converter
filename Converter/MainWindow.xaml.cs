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

namespace Converter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rateE.Text);
            double sumEuro = Convert.ToDouble(sumE.Text);
            double resDouble = rateEuro * sumEuro;
            resSumE.Text = resDouble.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHriv = Convert.ToDouble(rateG.Text);
            double sumHriv = Convert.ToDouble(sumG.Text);
            double resDouble = rateHriv * sumHriv;
            resSumG.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rateD.Text);
            double sumDram = Convert.ToDouble(sumD.Text);
            double resDouble = rateDram * sumDram;
            resSumD.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double disInches = Convert.ToDouble(distanceI.Text);
            double resDouble = disInches * 0.0254;
            resDisI.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double disFeet = Convert.ToDouble(distanceF.Text);
            double resDouble = disFeet * 0.3048;
            resDisF.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double disMiles = Convert.ToDouble(distanceM.Text);
            double resDouble = disMiles * 1609.34;
            resDisM.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double disVerst = Convert.ToDouble(distanceV.Text);
            double resDouble = disVerst * 1066.8;
            resDisV.Text = resDouble.ToString();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            double disAng = Convert.ToDouble(distanceA.Text);
            double resDouble = disAng * Math.Pow(10,-10);
            resDisA.Text = resDouble.ToString();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            double disPar = Convert.ToDouble(distanceP.Text);
            double resDouble = disPar * 3.086*Math.Pow(10, 16);
            resDisP.Text = resDouble.ToString();
        }
    }
}
