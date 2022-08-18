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

namespace Wpf_Work_4
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
            rez_D.Text =Convert.ToString(Convert.ToDouble(curs_D.Text) * Convert.ToDouble(summa_D.Text));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                rez_G.Text = Convert.ToString(Convert.ToDouble(curs_G.Text) * Convert.ToDouble(summa_G.Text));
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            {
                rez_E.Text = Convert.ToString(Convert.ToDouble(curs_E.Text) * Convert.ToDouble(summa_E.Text));
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            {
                rez_A.Text = Convert.ToString(Convert.ToDouble(curs_A.Text) * Convert.ToDouble(summa_A.Text));
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            dist_D_m.Text = Convert.ToString(Convert.ToDouble(dist_D.Text) * 0.0254);//дюймы
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            dist_F_m.Text = Convert.ToString(Convert.ToDouble(dist_F.Text) * 0.3048);//футы
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            dist_M_m.Text = Convert.ToString(Convert.ToDouble(dist_M.Text) * 1609.34);//мили
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            dist_V_m.Text = Convert.ToString(Convert.ToDouble(dist_V.Text) * 1066.8);//версты
        }


    }
}
