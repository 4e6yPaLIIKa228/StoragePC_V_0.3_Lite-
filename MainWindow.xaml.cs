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

namespace StoragePC
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

        private void BtClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Bt_Reg_Click(object sender, RoutedEventArgs e)
        {
            Regist Regist = new Regist();
            this.Close();
            Regist.Show();
        }

        private void BtLog_Click(object sender, RoutedEventArgs e)
        {
            DateBaseFull f = new DateBaseFull();
            this.Close();
            f.Show();
        }

        private void test1_Click(object sender, RoutedEventArgs e)
        {
            Test1 a = new Test1();
            this.Close();
            a.Show();
        }
        //string login = Tx_Log.Text.Trim();
        //string pass = PassBx.Password.Trim();
        //if (login.Length < 4)
        //{   //Проверка,пароля на колл символов
        //    Tx_Log.ToolTip = "Это поле не введено не корректно";
        //    Tx_Log.Background = Brushes.Red;
        //}
        //else if (pass.Length < 4)
        //{
        //    PassBx.ToolTip = "Это поле не введено не корректно";
        //    PassBx.Background = Brushes.Red;
        //}
        //else
        //{
        //    Tx_Log.ToolTip = "";
        //    Tx_Log.Background = Brushes.Transparent;
        //    PassBx.ToolTip = "";
        //    PassBx.Background = Brushes.Transparent;


        //    Teacher autTeacer = null;
        //    using (ApplicationContext db = new ApplicationContext())
        //    {
        //        //autTeacer = db.Teachers.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault();
        //    }

        //    if (autTeacer != null)
        //        MessageBox.Show("Okey!");
        //    else
        //        MessageBox.Show("ERROW");

    }
}

