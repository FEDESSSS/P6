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
using System.Windows.Shapes;

namespace Пр6
{
    /// <summary>
    /// Логика взаимодействия для Win3.xaml
    /// </summary>
    public partial class Win3 : Window
    {
        public Win3(string name, string age, string email, BitmapSource bitmapSource)
        {
            InitializeComponent();
            lb1.Content = name;
            lb2.Content = age;
            lb3.Content = email;
            SelImage.Source = bitmapSource;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Win2 win2 = new Win2();
            win2.Show();
        }
    }
}
