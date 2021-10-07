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
using System.Data.Entity;

namespace StoragePC
{
    /// <summary>
    /// Логика взаимодействия для Regist.xaml
    /// </summary>
    public partial class Regist : Window
    {
        ApplicationContext db;
        public Regist()
        {
            InitializeComponent();

            db = new ApplicationContext();

            //List<Teacher> prow = db.Teachers.ToList();
            //string str = " ";
            //foreach (Teacher login in prow)
            //    str += "login: " + login.Login + " / ";

            //exampleText.Text = str;
        }

        private void Bt_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow b = new MainWindow();
            this.Close();
            b.Show();
        }

        private void Bt_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = Tx_Log.Text.Trim();
            string pass = PassBx.Password.Trim();
            if (login.Length < 4)
            {   //Проверка,пароля на колл символов
                Tx_Log.ToolTip = "Это поле не введено не корректно";
                Tx_Log.Background = Brushes.Red;
            }
            else if (pass.Length < 4)
            {
                PassBx.ToolTip = "Это поле не введено не корректно";
                PassBx.Background = Brushes.Red;
            }
            else
            {
                Tx_Log.ToolTip = "";
                Tx_Log.Background = Brushes.Transparent;
                PassBx.ToolTip = "";
                PassBx.Background = Brushes.Transparent;
                MessageBox.Show("Okey!");

                Teacher teacher = new Teacher(login, pass);
                //db.Teachers.Add(teacher);
                db.SaveChanges();
            }
        }
            
    }
}
