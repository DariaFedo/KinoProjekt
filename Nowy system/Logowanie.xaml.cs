using Nowy_system.ListsControls;
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
using CTS = Cinema.Ticket.System;

namespace Nowy_system
{
    /// <summary>
    /// Logika interakcji dla klasy Logowanie.xaml
    /// </summary>
    public partial class Logowanie : Window
    {
        CTS.System Program;
        public Logowanie(CTS.System program)
        {
            InitializeComponent(); ;
            this.Program = program;
            UserPanel UP = new UserPanel(Program);

        }
        public bool lpoint = false;
        public void Submit_Click(object sender, RoutedEventArgs e)
        {
            string login = Login.Text;
            string password = Password.Password;
            if (Program.Log(login, password))
            {
                lpoint = true;
                this.Close();
                lpoint = false;
            }
            else
            {
                MessageBox.Show("Not correct Login or Password");
            };
        }
    }
}
