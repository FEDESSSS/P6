using Microsoft.Win32;
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
    /// Логика взаимодействия для Win2.xaml
    /// </summary>
    public partial class Win2 : Window
    {
        public Win2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png",
                Title = "Выберите изображение"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                var bitmap = new BitmapImage(new Uri(filePath)); 
                SelectedImage.Source = bitmap;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mainWindow = new MainWindow(); 
            mainWindow.Show(); 
        }

      
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (tx3.Text == "")
            {
                MessageBox.Show("Вы не заполнили поле Email", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            string Name = tx1.Text; 
            string Age = tx2.Text;
            string Email = tx3.Text;
            

           
            BitmapSource bitmapSource = SelectedImage.Source as BitmapSource;

            if (bitmapSource != null)
            {
                
            }
            else
            {
                MessageBox.Show("Пожалуйста, загрузите изображение.");
                return;
            }
            this.Hide();
            Win3 win3 = new Win3(Name, Age, Email, bitmapSource);
            win3.Show();
        }
    }
}
