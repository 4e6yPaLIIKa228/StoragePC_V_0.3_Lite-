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

namespace StoragePC
{
    /// <summary>
    /// Логика взаимодействия для DateBase.xaml
    /// </summary>
    public partial class DateBase : Window
    {
            public Device Device { get; private set; }

            public DateBase(Device p)
            {
                InitializeComponent();
                Device = p;
                this.DataContext = Device;
            }

            private void Accept_Click(object sender, RoutedEventArgs e)
    {  
            if (String.IsNullOrEmpty(TexBxName.Text) || String.IsNullOrEmpty(TexBxNumber.Text) || String.IsNullOrEmpty(TexBxtype.Text) || String.IsNullOrEmpty(TexBxKab.Text)) //Проверка,если ничего не ввели
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                this.DialogResult = true;
            }
    }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "йцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХФЫВАПРОЛДЖЭЯЧСМИТБЮ".IndexOf(e.Text) < 0; //Только буквы(очень спорно)
        }
    }

}
